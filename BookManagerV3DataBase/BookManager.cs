using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.BarCode.Generation;
using Npgsql;

namespace BookManagerV3DataBase
{
    internal class BookManager
    {
        public void AddBook(string title,string author,int year,string discrition,string file_url)
        {
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["book_manager_connection"].ConnectionString);
            conn.Open();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from  add_book(\'{title}\',\'{author}\',\'{year}\',\'{discrition}\',\'{file_url}\');";

            NpgsqlDataReader dataReader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            cmd.Dispose();
            conn.Close();
        }
        public DataTable PrintAllBook()
        {
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["book_manager_connection"].ConnectionString);
            conn.Open();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from  print_all_book();";

            NpgsqlDataReader dataReader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            cmd.Dispose();
            conn.Close();

            return dataTable;
        }
        public DataTable filter_book_on_author(string authorBook)
        {
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["book_manager_connection"].ConnectionString);
            conn.Open();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from  filter_book_on_author(\"{authorBook}\");";

            NpgsqlDataReader dataReader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            cmd.Dispose();
            conn.Close();

            return dataTable;
        }
        public DataTable filter_book_on_title(string titleBook)
        {
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["book_manager_connection"].ConnectionString);
            conn.Open();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from  filter_book_on_title(\"{titleBook}\");";

            NpgsqlDataReader dataReader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            cmd.Dispose();
            conn.Close();

            return dataTable;
        }
        private string SELECT_description(string title, string author)
        {
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["book_manager_connection"].ConnectionString);
            conn.Open();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select description from \"Book\" where author=\'{author}\' and title=\'{title}\';";

            NpgsqlDataReader dataReader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            cmd.Dispose();
            conn.Close();

            return dataTable.ToString();

        }
        public void QR_code(string title,string author)
        {
            string description=SELECT_description(title, author);
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Название: {title}\n");
            stringBuilder.AppendLine($"Автор:{author}\n");
            stringBuilder.AppendLine($"Описание: {description}");

            var generator = new BarcodeGenerator(EncodeTypes.QR);

            // Укажите текст кода для кодирования
            generator.CodeText = stringBuilder.ToString();

            // Укажите размер изображения
            generator.Parameters.Barcode.XDimension.Pixels = 8;
            generator.Parameters.Resolution = 500;

            // Сохраните сгенерированный QR-код
            generator.Save("C:\\texlive\\Text_QR_Code.jpg");
        }
    }
}
