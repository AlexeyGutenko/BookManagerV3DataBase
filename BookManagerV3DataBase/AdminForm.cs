using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Words;


namespace BookManagerV3DataBase
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        BookManager bookManager = new BookManager();
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAuthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void publicationYearTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIdBook_TextChanged(object sender, EventArgs e)
        {

        }


        private void addBook_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            string author = textBoxAuthor.Text;
            int year = Convert.ToInt32(publicationYearTextBox.Text);
            string description = textBoxDescription.Text;

            // Выбор входного файла
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Word Documents (*.docx)|*.docx|PDF Documents (*.pdf)|*.pdf";
            openFileDialog.Title = "Выберите документ (Word или PDF)";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            string inputFilePath = openFileDialog.FileName;
            // Заранее выбранная папка для сохранения
            string outputFolderPath = "C:\\book"; // Укажите вашу целевую папку

            // Извлечение имени файла без расширения
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(inputFilePath);
            string outputFileName = fileNameWithoutExtension + ".pdf";
            string outputFilePath = Path.Combine(outputFolderPath, outputFileName);
            // Сохранение полного пути в переменную file_URL
            string file_URL = outputFilePath;
            try
            {
                // Преобразование в PDF, если файл Word
                if (openFileDialog.FilterIndex == 1) // Если выбран файл Word
                {
                    Document doc = new Document(inputFilePath);
                    doc.Save(outputFilePath, SaveFormat.Pdf);
                }
                else if (openFileDialog.FilterIndex == 2) // Если выбран файл PDF
                {
                    // Если вам нужно только копировать PDF файл в выходную папку, используем File.Copy
                    File.Copy(inputFilePath, outputFilePath, true);
                }
                MessageBox.Show($"Документ успешно обработан и сохранен в папку '{outputFolderPath}' как '{outputFileName}'. Полный путь: '{file_URL}'", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bookManager.AddBook(title, author, year, description, file_URL);
        }

        private void removeBook_Click(object sender, EventArgs e)
        {

        }


        private void findByAuthor_Click(object sender, EventArgs e)
        {
            string author = textBoxAuthor.Text;

            dataGridView1.DataSource = bookManager.filter_book_on_author(author);
        }

        private void printAllBook_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bookManager.PrintAllBook();
        }

        private void findByTitle_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            dataGridView1.DataSource = bookManager.filter_book_on_title(title);
        }


        private void export_Click(object sender, EventArgs e)
        {

            // Папка, которую нужно заархивировать
            string sourceFolder = "C:\\book";

            // Настройка диалога для сохранения ZIP-файла
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Сохранить ZIP-архив";
            saveFileDialog.Filter = "ZIP Files (*.zip)|*.zip";
            saveFileDialog.FileName = "exported_files.zip"; // Имя по умолчанию

            // Показываем диалог и проверяем, что пользователь выбрал путь
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string zipFilePath = saveFileDialog.FileName; // Полный путь сохранения файла

            try
            {
                // Проверяем, существует ли папка с файлами
                if (Directory.Exists(sourceFolder))
                {
                    // Удаляем существующий ZIP-файл, если он уже существует
                    if (File.Exists(zipFilePath))
                    {
                        File.Delete(zipFilePath);
                    }

                    // Создаем ZIP-архив из источника
                    ZipFile.CreateFromDirectory(sourceFolder, zipFilePath);
                    MessageBox.Show($"Все файлы из '{sourceFolder}' успешно заархивированы в '{zipFilePath}'.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Папка '{sourceFolder}' не существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Zip files (*.zip)|*.zip",
                Title = "Выберите zip-архив с книгами"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string zipFilePath = openFileDialog.FileName;
                string extractPath = Path.Combine(Path.GetTempPath(), "import_files");

                // Распаковка zip-архива
                ZipFile.ExtractToDirectory(zipFilePath, extractPath);

                // Путь к текстовому файлу с данными о книгах
                string booksInfoFilePath = Path.Combine(extractPath, "books_info.txt");

                // Чтение текстового файла с данными о книгах
                foreach (var line in File.ReadLines(booksInfoFilePath))
                {
                    // Предполагается, что данные разделены запятыми
                    var parts = line.Split(',');
                    if (parts.Length == 5)
                    {
                        string title = parts[0].Trim();
                        string author = parts[1].Trim();
                        int year = int.Parse(parts[2].Trim());
                        string description = parts[3].Trim();
                        string fileUrl = parts[4].Trim();

                        // Перемещение файла книги в папку назначения
                        string sourceFilePath = Path.Combine(extractPath, fileUrl);
                        string destinationFilePath = Path.Combine("C:\\book", Path.GetFileName(sourceFilePath));

                        // Перемещение файла
                        File.Move(sourceFilePath, destinationFilePath);
                        bookManager.AddBook(title, author, year, description, destinationFilePath);
                    }
                }
            }
        }


        private void QrCode_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            string author = textBoxAuthor.Text;
            bookManager.QR_code(title, author);
        }


        private void addUser_Click(object sender, EventArgs e)
        {
            FormUserAdd formUserAdd = new FormUserAdd();
            formUserAdd.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            authorization authorization = new authorization();
            authorization.Show();
            this.Hide();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
