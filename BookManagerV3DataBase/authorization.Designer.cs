namespace BookManagerV3DataBase
{
    partial class authorization
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            logIn = new Button();
            label1 = new Label();
            label2 = new Label();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            SuspendLayout();
            // 
            // logIn
            // 
            logIn.Location = new Point(83, 100);
            logIn.Name = "logIn";
            logIn.Size = new Size(75, 23);
            logIn.TabIndex = 5;
            logIn.Text = "войти";
            logIn.UseVisualStyleBackColor = true;
            logIn.Click += logIn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 6;
            label1.Text = "логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 7;
            label2.Text = "пароль";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(65, 17);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(150, 23);
            textBoxLogin.TabIndex = 8;
            textBoxLogin.TextChanged += textBoxLogin_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(65, 71);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(150, 23);
            textBoxPassword.TabIndex = 9;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // authorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 326);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(logIn);
            Name = "authorization";
            Text = "authorization";
            Load += authorization_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private Button logIn;
        private Label label1;
        private Label label2;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;

    }
}