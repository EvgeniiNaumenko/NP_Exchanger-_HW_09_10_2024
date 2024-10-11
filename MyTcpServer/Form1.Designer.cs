namespace MyTcpServer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            StartServerButton = new Button();
            ServerStatus = new Label();
            OpenLogButton = new Button();
            SuspendLayout();
            // 
            // StartServerButton
            // 
            StartServerButton.Location = new Point(70, 82);
            StartServerButton.Name = "StartServerButton";
            StartServerButton.Size = new Size(200, 45);
            StartServerButton.TabIndex = 0;
            StartServerButton.Text = "START";
            StartServerButton.UseVisualStyleBackColor = true;
            StartServerButton.Click += StartServerButton_Click;
            // 
            // ServerStatus
            // 
            ServerStatus.AutoSize = true;
            ServerStatus.Location = new Point(113, 39);
            ServerStatus.Name = "ServerStatus";
            ServerStatus.Size = new Size(104, 20);
            ServerStatus.TabIndex = 2;
            ServerStatus.Text = "Server : offline";
            // 
            // OpenLogButton
            // 
            OpenLogButton.Location = new Point(70, 147);
            OpenLogButton.Name = "OpenLogButton";
            OpenLogButton.Size = new Size(200, 45);
            OpenLogButton.TabIndex = 3;
            OpenLogButton.Text = "Открыть логи";
            OpenLogButton.UseVisualStyleBackColor = true;
            OpenLogButton.Click += OpenLogButton_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(339, 228);
            Controls.Add(OpenLogButton);
            Controls.Add(ServerStatus);
            Controls.Add(StartServerButton);
            Name = "Form1";
            Text = "Currency Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartServerButton;
        private Label ServerStatus;
        private Button OpenLogButton;
    }
}
