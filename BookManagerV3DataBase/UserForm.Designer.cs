namespace BookManagerV3DataBase
{
    partial class UserForm
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
            export = new Button();
            textBoxIdBook = new TextBox();
            textBoxAuthor = new TextBox();
            lableAuthor = new Label();
            publicationYearTextBox = new TextBox();
            label4 = new Label();
            textBoxDescription = new TextBox();
            label3 = new Label();
            labelIdBook = new Label();
            textBoxTitle = new TextBox();
            label1 = new Label();
            exit = new Button();
            findByAuthor = new Button();
            findByTitle = new Button();
            printAllBook = new Button();
            QrCode = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // export
            // 
            export.Location = new Point(778, 373);
            export.Name = "export";
            export.Size = new Size(138, 48);
            export.TabIndex = 43;
            export.Text = "экспартировать книги";
            export.UseVisualStyleBackColor = true;
            export.Click += export_Click;
            // 
            // textBoxIdBook
            // 
            textBoxIdBook.Location = new Point(922, 149);
            textBoxIdBook.Multiline = true;
            textBoxIdBook.Name = "textBoxIdBook";
            textBoxIdBook.Size = new Size(255, 37);
            textBoxIdBook.TabIndex = 42;
            textBoxIdBook.TextChanged += textBoxIdBook_TextChanged;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(922, 20);
            textBoxAuthor.Multiline = true;
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(255, 37);
            textBoxAuthor.TabIndex = 41;
            textBoxAuthor.TextChanged += textBoxAuthor_TextChanged;
            // 
            // lableAuthor
            // 
            lableAuthor.AutoSize = true;
            lableAuthor.Location = new Point(858, 23);
            lableAuthor.Name = "lableAuthor";
            lableAuthor.Size = new Size(40, 15);
            lableAuthor.TabIndex = 40;
            lableAuthor.Text = "Автор";
            // 
            // publicationYearTextBox
            // 
            publicationYearTextBox.Location = new Point(922, 63);
            publicationYearTextBox.Multiline = true;
            publicationYearTextBox.Name = "publicationYearTextBox";
            publicationYearTextBox.Size = new Size(255, 37);
            publicationYearTextBox.TabIndex = 39;
            publicationYearTextBox.TextChanged += publicationYearTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(796, 66);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 38;
            label4.Text = "Дата публикации";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(922, 106);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(255, 37);
            textBoxDescription.TabIndex = 37;
            textBoxDescription.TextChanged += textBoxDescription_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(839, 109);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 36;
            label3.Text = "описание";
            // 
            // labelIdBook
            // 
            labelIdBook.AutoSize = true;
            labelIdBook.Location = new Point(880, 152);
            labelIdBook.Name = "labelIdBook";
            labelIdBook.Size = new Size(18, 15);
            labelIdBook.TabIndex = 35;
            labelIdBook.Text = "ID";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(732, -39);
            textBoxTitle.Multiline = true;
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(255, 37);
            textBoxTitle.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(649, -36);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 33;
            label1.Text = "Название";
            // 
            // exit
            // 
            exit.Location = new Point(1135, 516);
            exit.Name = "exit";
            exit.Size = new Size(75, 23);
            exit.TabIndex = 31;
            exit.Text = "выход";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // findByAuthor
            // 
            findByAuthor.Location = new Point(922, 323);
            findByAuthor.Name = "findByAuthor";
            findByAuthor.Size = new Size(138, 44);
            findByAuthor.TabIndex = 29;
            findByAuthor.Text = "фильтр по автору";
            findByAuthor.UseVisualStyleBackColor = true;
            findByAuthor.Click += findByAuthor_Click;
            // 
            // findByTitle
            // 
            findByTitle.Location = new Point(922, 373);
            findByTitle.Name = "findByTitle";
            findByTitle.Size = new Size(138, 48);
            findByTitle.TabIndex = 28;
            findByTitle.Text = "поиск по названию";
            findByTitle.UseVisualStyleBackColor = true;
            findByTitle.Click += findByTitle_Click;
            // 
            // printAllBook
            // 
            printAllBook.Location = new Point(1072, 323);
            printAllBook.Name = "printAllBook";
            printAllBook.Size = new Size(138, 44);
            printAllBook.TabIndex = 27;
            printAllBook.Text = "вывести все книги";
            printAllBook.UseVisualStyleBackColor = true;
            printAllBook.Click += printAllBook_Click;
            // 
            // QrCode
            // 
            QrCode.Location = new Point(1072, 373);
            QrCode.Name = "QrCode";
            QrCode.Size = new Size(138, 48);
            QrCode.TabIndex = 26;
            QrCode.Text = "QR-код";
            QrCode.UseVisualStyleBackColor = true;
            QrCode.Click += QrCode_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(727, 585);
            dataGridView1.TabIndex = 24;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 598);
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
            Controls.Add(exit);
            Controls.Add(findByAuthor);
            Controls.Add(findByTitle);
            Controls.Add(printAllBook);
            Controls.Add(QrCode);
            Controls.Add(dataGridView1);
            Name = "UserForm";
            Text = "UserForm";
            Load += UserForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button export;
        private TextBox textBoxIdBook;
        private TextBox textBoxAuthor;
        private Label lableAuthor;
        private TextBox publicationYearTextBox;
        private Label label4;
        private TextBox textBoxDescription;
        private Label label3;
        private Label labelIdBook;
        private TextBox textBoxTitle;
        private Label label1;
        private Button exit;
        private Button findByAuthor;
        private Button findByTitle;
        private Button printAllBook;
        private Button QrCode;
        private DataGridView dataGridView1;
    }
}