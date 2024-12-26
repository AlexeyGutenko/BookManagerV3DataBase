namespace BookManagerV3DataBase
{
    partial class AdminForm
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
            addBook = new Button();
            QrCode = new Button();
            printAllBook = new Button();
            findByTitle = new Button();
            findByAuthor = new Button();
            removeBook = new Button();
            exit = new Button();
            addUser = new Button();
            label1 = new Label();
            textBoxTitle = new TextBox();
            labelIdBook = new Label();
            textBoxDescription = new TextBox();
            label3 = new Label();
            publicationYearTextBox = new TextBox();
            label4 = new Label();
            textBoxAuthor = new TextBox();
            lableAuthor = new Label();
            textBoxIdBook = new TextBox();
            export = new Button();
            import = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(727, 585);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // addBook
            // 
            addBook.Location = new Point(748, 315);
            addBook.Name = "addBook";
            addBook.Size = new Size(138, 44);
            addBook.TabIndex = 1;
            addBook.Text = "добавть книгу";
            addBook.UseVisualStyleBackColor = true;
            addBook.Click += addBook_Click;
            // 
            // QrCode
            // 
            QrCode.Location = new Point(1042, 365);
            QrCode.Name = "QrCode";
            QrCode.Size = new Size(138, 48);
            QrCode.TabIndex = 2;
            QrCode.Text = "QR-код";
            QrCode.UseVisualStyleBackColor = true;
            QrCode.Click += QrCode_Click;
            // 
            // printAllBook
            // 
            printAllBook.Location = new Point(1042, 315);
            printAllBook.Name = "printAllBook";
            printAllBook.Size = new Size(138, 44);
            printAllBook.TabIndex = 3;
            printAllBook.Text = "вывести все книги";
            printAllBook.UseVisualStyleBackColor = true;
            printAllBook.Click += printAllBook_Click;
            // 
            // findByTitle
            // 
            findByTitle.Location = new Point(892, 365);
            findByTitle.Name = "findByTitle";
            findByTitle.Size = new Size(138, 48);
            findByTitle.TabIndex = 4;
            findByTitle.Text = "поиск по названию";
            findByTitle.UseVisualStyleBackColor = true;
            findByTitle.Click += findByTitle_Click;
            // 
            // findByAuthor
            // 
            findByAuthor.Location = new Point(892, 315);
            findByAuthor.Name = "findByAuthor";
            findByAuthor.Size = new Size(138, 44);
            findByAuthor.TabIndex = 5;
            findByAuthor.Text = "фильтр по автору";
            findByAuthor.UseVisualStyleBackColor = true;
            findByAuthor.Click += findByAuthor_Click;
            // 
            // removeBook
            // 
            removeBook.Location = new Point(892, 438);
            removeBook.Name = "removeBook";
            removeBook.Size = new Size(138, 50);
            removeBook.TabIndex = 8;
            removeBook.Text = "удалить книгу";
            removeBook.UseVisualStyleBackColor = true;
            removeBook.Click += removeBook_Click;
            // 
            // exit
            // 
            exit.Location = new Point(1105, 574);
            exit.Name = "exit";
            exit.Size = new Size(75, 23);
            exit.TabIndex = 9;
            exit.Text = "выход";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // addUser
            // 
            addUser.Location = new Point(748, 438);
            addUser.Name = "addUser";
            addUser.Size = new Size(138, 50);
            addUser.TabIndex = 10;
            addUser.Text = "добавить пользователя";
            addUser.UseVisualStyleBackColor = true;
            addUser.Click += addUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(842, 43);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 11;
            label1.Text = "Название";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(925, 40);
            textBoxTitle.Multiline = true;
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(255, 37);
            textBoxTitle.TabIndex = 12;
            textBoxTitle.TextChanged += textBoxTitle_TextChanged;
            // 
            // labelIdBook
            // 
            labelIdBook.AutoSize = true;
            labelIdBook.Location = new Point(883, 218);
            labelIdBook.Name = "labelIdBook";
            labelIdBook.Size = new Size(18, 15);
            labelIdBook.TabIndex = 13;
            labelIdBook.Text = "ID";
            labelIdBook.Click += label2_Click;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(925, 172);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(255, 37);
            textBoxDescription.TabIndex = 16;
            textBoxDescription.TextChanged += textBoxDescription_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(842, 175);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 15;
            label3.Text = "описание";
            // 
            // publicationYearTextBox
            // 
            publicationYearTextBox.Location = new Point(925, 129);
            publicationYearTextBox.Multiline = true;
            publicationYearTextBox.Name = "publicationYearTextBox";
            publicationYearTextBox.Size = new Size(255, 37);
            publicationYearTextBox.TabIndex = 18;
            publicationYearTextBox.TextChanged += publicationYearTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(799, 132);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 17;
            label4.Text = "Дата публикации";
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(925, 86);
            textBoxAuthor.Multiline = true;
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(255, 37);
            textBoxAuthor.TabIndex = 20;
            textBoxAuthor.TextChanged += textBoxAuthor_TextChanged;
            // 
            // lableAuthor
            // 
            lableAuthor.AutoSize = true;
            lableAuthor.Location = new Point(861, 89);
            lableAuthor.Name = "lableAuthor";
            lableAuthor.Size = new Size(40, 15);
            lableAuthor.TabIndex = 19;
            lableAuthor.Text = "Автор";
            // 
            // textBoxIdBook
            // 
            textBoxIdBook.Location = new Point(925, 215);
            textBoxIdBook.Multiline = true;
            textBoxIdBook.Name = "textBoxIdBook";
            textBoxIdBook.Size = new Size(255, 37);
            textBoxIdBook.TabIndex = 21;
            textBoxIdBook.TextChanged += textBoxIdBook_TextChanged;
            // 
            // export
            // 
            export.Location = new Point(748, 365);
            export.Name = "export";
            export.Size = new Size(138, 48);
            export.TabIndex = 22;
            export.Text = "экспартировать книги";
            export.UseVisualStyleBackColor = true;
            export.Click += export_Click;
            // 
            // import
            // 
            import.Location = new Point(1042, 438);
            import.Name = "import";
            import.Size = new Size(138, 50);
            import.TabIndex = 23;
            import.Text = "импортировать книги";
            import.UseVisualStyleBackColor = true;
            import.Click += import_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 609);
            Controls.Add(import);
            Controls.Add(export);
            Controls.Add(textBoxIdBook);
            Controls.Add(textBoxAuthor);
            Controls.Add(lableAuthor);
            Controls.Add(publicationYearTextBox);
            Controls.Add(label4);
            Controls.Add(textBoxDescription);
            Controls.Add(label3);
            Controls.Add(labelIdBook);
            Controls.Add(textBoxTitle);
            Controls.Add(label1);
            Controls.Add(addUser);
            Controls.Add(exit);
            Controls.Add(removeBook);
            Controls.Add(findByAuthor);
            Controls.Add(findByTitle);
            Controls.Add(printAllBook);
            Controls.Add(QrCode);
            Controls.Add(addBook);
            Controls.Add(dataGridView1);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button addBook;
        private Button QrCode;
        private Button printAllBook;
        private Button findByTitle;
        private Button findByAuthor;
        private Button removeBook;
        private Button exit;
        private Button addUser;
        private Label label1;
        private TextBox textBoxTitle;
        private Label labelIdBook;
        private TextBox textBoxDescription;
        private Label label3;
        private TextBox publicationYearTextBox;
        private Label label4;
        private TextBox textBoxAuthor;
        private Label lableAuthor;
        private TextBox textBoxIdBook;
        private Button export;
        private Button import;
    }
}