using System.Net.Sockets;
using System.Net;
using System.Text;
using System.IO;

namespace MyTcpClient
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private string server = "127.0.0.1";
        private int port = 13000;
        public Form1()
        {
            InitializeComponent();
        }

        private void GetRatioCurButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CurVal1.Text) || string.IsNullOrEmpty(CurVal2.Text))
            {
                MessageBox.Show("Введите обе валюты.");
                return;
            }
            try
            {
                using (TcpClient client = new TcpClient(server, port))
                {
                    NetworkStream stream = client.GetStream();

                    byte[] requestData = Encoding.UTF8.GetBytes(CurVal1.Text.Trim() + " " + CurVal2.Text.Trim());
                    stream.Write(requestData, 0, requestData.Length);

                    byte[] buffer = new byte[256];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    if (response.Contains("ERROR"))
                    {
                        ResultTextBox.Text = response;
                    }
                    else
                    {
                        ResultTextBox.Text = $"Отношение :  1 {CurVal1.Text.Trim()}  = {response} {CurVal2.Text.Trim()}";
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ошибка:" + Ex.Message);
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (client != null)
            {
                client.Close();
            }
        }
        private void AvailableCurrencyButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (TcpClient client = new TcpClient(server, port))
                {
                    NetworkStream stream = client.GetStream();

                    byte[] requestData = Encoding.UTF8.GetBytes("$");
                    stream.Write(requestData, 0, requestData.Length);

                    byte[] buffer = new byte[512];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    AvailableCurrency.Text = response;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ошибка:" + Ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string buffer = CurVal1.Text;
            CurVal1.Text = CurVal2.Text;
            CurVal2.Text = buffer;
        }
    }
}
