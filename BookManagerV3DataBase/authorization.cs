using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagerV3DataBase
{
    public partial class authorization : Form
    {
        public authorization()
        {
            InitializeComponent();
        }

        private void authorization_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';

        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void logIn_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;

            using (NpgsqlConnection conn = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["book_manager_connection"].ConnectionString))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;

                    // Запрос на получение хешированного пароля и роли пользователя
                    cmd.CommandText = "SELECT password, role FROM \"User\" WHERE login = @login;";
                    cmd.Parameters.AddWithValue("login", login);

                    // Выполняем команду и получаем результат
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string hashedPassword = reader.GetString(0); // Получаем хешированный пароль
                            string role = reader.GetString(1); // Получаем роль

                            // Проверяем пароль
                            if (PasswordHasher.VerifyPassword(password, hashedPassword))
                            {
                                
                                if (role=="admin")
                                {
                                    AdminForm adminForm = new AdminForm();
                                    adminForm.Show();
                                    this.Hide();
                                }
                                if (role == "user")
                                {
                                    UserForm userForm = new UserForm();
                                    userForm.Show();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                // Неверный пароль
                                MessageBox.Show("Неверный логин или пароль.");
                            }
                        }
                        else
                        {
                            // Пользователь не найден
                            MessageBox.Show("Неверный логин или пароль.");
                        }
                    }
                }
            }
        }



    }
}
