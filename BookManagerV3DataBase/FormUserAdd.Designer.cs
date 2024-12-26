namespace BookManagerV3DataBase
{
    partial class FormUserAdd
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            textBoxEMail = new TextBox();
            textBoxPatrnymic = new TextBox();
            textBoxSurname = new TextBox();
            textBoxName = new TextBox();
            print_all_user = new Button();
            removeUser = new Button();
            addUser = new Button();
            findUser = new Button();
            comboBoxRole = new ComboBox();
            exit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(854, 622);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(892, 10);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(897, 48);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 2;
            label2.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(897, 79);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 3;
            label3.Text = "Роль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(892, 122);
            label4.Name = "label4";
            label4.Size = new Size(113, 15);
            label4.TabIndex = 4;
            label4.Text = "Электронная почта";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(892, 168);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 5;
            label5.Text = "Имя";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(892, 204);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 6;
            label6.Text = "Фамилия";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(892, 256);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 7;
            label7.Text = "Отчество";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(1002, 10);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(199, 23);
            textBoxLogin.TabIndex = 9;
            textBoxLogin.TextChanged += textBoxLogin_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(1002, 45);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(199, 23);
            textBoxPassword.TabIndex = 10;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // textBoxEMail
            // 
            textBoxEMail.Location = new Point(1002, 122);
            textBoxEMail.Name = "textBoxEMail";
            textBoxEMail.Size = new Size(199, 23);
            textBoxEMail.TabIndex = 11;
            textBoxEMail.TextChanged += textBoxEMail_TextChanged;
            // 
            // textBoxPatrnymic
            // 
            textBoxPatrnymic.Location = new Point(1001, 248);
            textBoxPatrnymic.Name = "textBoxPatrnymic";
            textBoxPatrnymic.Size = new Size(199, 23);
            textBoxPatrnymic.TabIndex = 12;
            textBoxPatrnymic.TextChanged += textBoxPatrnymic_TextChanged;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(1001, 204);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(199, 23);
            textBoxSurname.TabIndex = 13;
            textBoxSurname.TextChanged += textBoxSurname_TextChanged;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(1001, 160);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(199, 23);
            textBoxName.TabIndex = 14;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // print_all_user
            // 
            print_all_user.Location = new Point(904, 309);
            print_all_user.Name = "print_all_user";
            print_all_user.Size = new Size(193, 75);
            print_all_user.TabIndex = 15;
            print_all_user.Text = "вывод всех пользователей";
            print_all_user.UseVisualStyleBackColor = true;
            print_all_user.Click += print_all_user_Click;
            // 
            // removeUser
            // 
            removeUser.Location = new Point(1103, 309);
            removeUser.Name = "removeUser";
            removeUser.Size = new Size(193, 75);
            removeUser.TabIndex = 17;
            removeUser.Text = "удалить пользователя";
            removeUser.UseVisualStyleBackColor = true;
            removeUser.Click += removeUser_Click;
            // 
            // addUser
            // 
            addUser.Location = new Point(1103, 390);
            addUser.Name = "addUser";
            addUser.Size = new Size(193, 75);
            addUser.TabIndex = 18;
            addUser.Text = "добавить пользователя";
            addUser.UseVisualStyleBackColor = true;
            addUser.Click += addUser_Click;
            // 
            // findUser
            // 
            findUser.Location = new Point(904, 390);
            findUser.Name = "findUser";
            findUser.Size = new Size(193, 75);
            findUser.TabIndex = 19;
            findUser.Text = "поиск пользователя";
            findUser.UseVisualStyleBackColor = true;
            findUser.Click += findUser_Click;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "user", "admin" });
            comboBoxRole.Location = new Point(1003, 82);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(198, 23);
            comboBoxRole.TabIndex = 20;
            comboBoxRole.SelectedIndexChanged += comboBoxRole_SelectedIndexChanged;
            // 
            // exit
            // 
            exit.Location = new Point(1203, 609);
            exit.Name = "exit";
            exit.Size = new Size(75, 23);
            exit.TabIndex = 21;
            exit.Text = "выход";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // FormUserAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1307, 642);
            Controls.Add(exit);
            Controls.Add(comboBoxRole);
            Controls.Add(findUser);
            Controls.Add(addUser);
            Controls.Add(removeUser);
            Controls.Add(print_all_user);
            Controls.Add(textBoxName);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxPatrnymic);
            Controls.Add(textBoxEMail);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FormUserAdd";
            Text = "FormUserAdd";
            Load += FormUserAdd_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private TextBox textBoxEMail;
        private TextBox textBoxPatrnymic;
        private TextBox textBoxSurname;
        private TextBox textBoxName;
        private Button print_all_user;
        private Button removeUser;
        private Button addUser;
        private Button findUser;
        private ComboBox comboBoxRole;
        private Button exit;
    }
}