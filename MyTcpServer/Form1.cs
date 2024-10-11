using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace MyTcpServer
{
    public partial class Form1 : Form
    {
        private TcpListener server;
        private string serverId = "127.0.0.1";
        private int port = 13000;
        private Dictionary<string, double> exchangeRates = new Dictionary<string, double>
        {
            { "USD", 1.0 },  
            { "EUR", 1.05 }, 
            { "GBP", 1.22 },  
            { "JPY", 149.00 }, 
            { "CHF", 0.91 },
            { "AUD", 0.63 },   
            { "CAD", 1.37 }, 
            { "NZD", 0.59 },  
            { "CNY", 7.30 },  
            { "UA", 41.00 }   
        };
        private static readonly string logFilePath = "server_log.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void StartServerButton_Click(object sender, EventArgs e)
        {
            try
            {
                server = new TcpListener(IPAddress.Parse(serverId), port);
                server.Start();
                Thread thread = new Thread(new ThreadStart(ThreadFun));
                thread.IsBackground = true;
                thread.Start();
                ServerStatus.Text = "Server: Online";
            }
            catch (SocketException sockEx)
            {
                MessageBox.Show("Ошибка сокета:" + sockEx.Message);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ошибка:" + Ex.Message);
            }
        }

        private void ThreadFun()
        {
            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                NetworkStream stream = client.GetStream();
                IPEndPoint clientEndPoint = (IPEndPoint)client.Client.RemoteEndPoint;
                string clientInfo = $"{clientEndPoint.Address}:{clientEndPoint.Port}";
                LogConnection(clientInfo, "Подключение");
                byte[] buffer = new byte[256];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string requestString = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                try
                {

                    if (requestString == "$")
                    {
                        string result = string.Join(", ", exchangeRates.Keys);
                        byte[] responseData = Encoding.UTF8.GetBytes(result);
                        stream.Write(responseData, 0, responseData.Length);
                        LogRequest(clientInfo, requestString, result);
                    }
                    else
                    {
                        string[] curAr = requestString.Split(" ");
                        string result = (ConvertCurrency(curAr[0], curAr[1])).ToString();
                        byte[] responseData = Encoding.UTF8.GetBytes(result);
                        stream.Write(responseData, 0, responseData.Length);
                        LogRequest(clientInfo, requestString, result);
                    }
                }
                catch (Exception ex)
                {
                    string errorMessage = "ERROR : Произошла ошибка на сервере: " + ex.Message;
                    byte[] errorData = Encoding.UTF8.GetBytes(errorMessage);
                    stream.Write(errorData, 0, errorData.Length);
                    LogRequest(clientInfo, requestString, errorMessage);
                }
                finally
                {
                    client.Close();
                    LogConnection(clientInfo, "Отключение");
                }
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (server != null)
            {
                server.Stop();
            }
        }
        private double ConvertCurrency(string fromCurrency, string toCurrency)
        {
            if (!exchangeRates.ContainsKey(fromCurrency) || !exchangeRates.ContainsKey(toCurrency))
            {
                throw new ArgumentException("Одна или обе валюты отсутствуют в списке.");
            }

            double amount = 1;

            double fromRate = exchangeRates[fromCurrency];

            double toRate = exchangeRates[toCurrency];

            double result = (amount / fromRate) * toRate;

            return result;
        }

        private static void LogConnection(string clientInfo, string status)
        {
            string logMessage = $"{DateTime.Now}: {clientInfo} - {status}";
            File.AppendAllText(logFilePath, logMessage + Environment.NewLine);
            Console.WriteLine(logMessage);
        }

        private static void LogRequest(string clientInfo, string request, string response)
        {
            string logMessage = $"{DateTime.Now}: {clientInfo} запрос: {request}, ответ: {response}";
            File.AppendAllText(logFilePath, logMessage + Environment.NewLine);
            Console.WriteLine(logMessage);
        }
    }
}
