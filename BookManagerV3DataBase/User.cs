using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagerV3DataBase
{
    internal class User
    {
     

        public void Add_User(string surname, string name, string patrnymic, string email, string login, string password, string role)
        {
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["book_manager_connection"].ConnectionString);
            conn.Open();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select from add_user({surname},{name},{patrnymic},{login},{password},{role},{email});";

            NpgsqlDataReader dataReader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            cmd.Dispose();
            conn.Close();
        }
        public DataTable printAllUser()
        {
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["book_manager_connection"].ConnectionString);
            conn.Open();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select print_all_user();";

            NpgsqlDataReader dataReader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            cmd.Dispose();
            conn.Close();

            return dataTable;
        }
        public DataTable removeUSer(string surname, string name, string patrnymic, string email, string login, string password, string role)
        {
            NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["book_manager_connection"].ConnectionString);
            conn.Open();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select * from delete_user({surname},{name},{patrnymic},{login},{password},{role},{email});";

            NpgsqlDataReader dataReader = cmd.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            cmd.Dispose();
            conn.Close();

            return dataTable;
        }

    }
}
