namespace MyTcpClient
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
            label1 = new Label();
            AvailableCurrency = new TextBox();
            ResultTextBox = new TextBox();
            GetRatioCurButton = new Button();
            label2 = new Label();
            label3 = new Label();
            CurVal1 = new TextBox();
            CurVal2 = new TextBox();
            label4 = new Label();
            AvailableCurrencyButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 0;
            label1.Text = "Доступные вылюты:";
            // 
            // AvailableCurrency
            // 
            AvailableCurrency.BackColor = SystemColors.Control;
            AvailableCurrency.BorderStyle = BorderStyle.FixedSingle;
            AvailableCurrency.Location = new Point(12, 32);
            AvailableCurrency.Multiline = true;
            AvailableCurrency.Name = "AvailableCurrency";
            AvailableCurrency.ReadOnly = true;
            AvailableCurrency.Size = new Size(264, 197);
            AvailableCurrency.TabIndex = 1;
            // 
            // ResultTextBox
            // 
            ResultTextBox.BackColor = SystemColors.Control;
            ResultTextBox.Location = new Point(298, 149);
            ResultTextBox.Multiline = true;
            ResultTextBox.Name = "ResultTextBox";
            ResultTextBox.ReadOnly = true;
            ResultTextBox.Size = new Size(540, 80);
            ResultTextBox.TabIndex = 2;
            // 
            // GetRatioCurButton
            // 
            GetRatioCurButton.Location = new Point(669, 25);
            GetRatioCurButton.Name = "GetRatioCurButton";
            GetRatioCurButton.Size = new Size(169, 68);
            GetRatioCurButton.TabIndex = 3;
            GetRatioCurButton.Text = "Запросить курс";
            GetRatioCurButton.UseVisualStyleBackColor = true;
            GetRatioCurButton.Click += GetRatioCurButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(465, 28);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 4;
            label2.Text = "Валюта 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(465, 117);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 5;
            label3.Text = "Валюта 2";
            // 
            // CurVal1
            // 
            CurVal1.Location = new Point(544, 25);
            CurVal1.Name = "CurVal1";
            CurVal1.Size = new Size(95, 27);
            CurVal1.TabIndex = 6;
            // 
            // CurVal2
            // 
            CurVal2.Location = new Point(543, 110);
            CurVal2.Name = "CurVal2";
            CurVal2.Size = new Size(96, 27);
            CurVal2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(298, 117);
            label4.Name = "label4";
            label4.Size = new Size(152, 20);
            label4.TabIndex = 8;
            label4.Text = "Соотношение валют";
            // 
            // AvailableCurrencyButton
            // 
            AvailableCurrencyButton.Location = new Point(298, 32);
            AvailableCurrencyButton.Name = "AvailableCurrencyButton";
            AvailableCurrencyButton.Size = new Size(115, 61);
            AvailableCurrencyButton.TabIndex = 9;
            AvailableCurrencyButton.Text = "Обновить";
            AvailableCurrencyButton.UseVisualStyleBackColor = true;
            AvailableCurrencyButton.Click += AvailableCurrencyButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(454, 67);
            button1.Name = "button1";
            button1.Size = new Size(193, 28);
            button1.TabIndex = 10;
            button1.Text = "Поменять местами";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 241);
            Controls.Add(button1);
            Controls.Add(AvailableCurrencyButton);
            Controls.Add(label4);
            Controls.Add(CurVal2);
            Controls.Add(CurVal1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(GetRatioCurButton);
            Controls.Add(ResultTextBox);
            Controls.Add(AvailableCurrency);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox AvailableCurrency;
        private TextBox ResultTextBox;
        private Button GetRatioCurButton;
        private Label label2;
        private Label label3;
        private TextBox CurVal1;
        private TextBox CurVal2;
        private Label label4;
        private Button AvailableCurrencyButton;
        private Button button1;
    }
}
