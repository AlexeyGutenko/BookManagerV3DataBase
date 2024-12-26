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

namespace BookManagerV3DataBase
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }
        BookManager bookManager = new BookManager();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void findByAuthor_Click(object sender, EventArgs e)
        {
            string author = textBoxAuthor.Text;

            dataGridView1.DataSource = bookManager.filter_book_on_author(author);
        }

        private void findByTitle_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            dataGridView1.DataSource = bookManager.filter_book_on_title(title);
        }

        private void printAllBook_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bookManager.PrintAllBook();
        }

        private void QrCode_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            string author = textBoxAuthor.Text;
            bookManager.QR_code(title, author);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            authorization authorization = new authorization();
            authorization.Show();
            this.Hide();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
