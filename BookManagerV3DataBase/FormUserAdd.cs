using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BookManagerV3DataBase
{
    public partial class FormUserAdd : Form
    {
        public FormUserAdd()
        {
            InitializeComponent();
        }
        User user = new User();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPatrnymic_TextChanged(object sender, EventArgs e)
        {

        }


        private void print_all_user_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = user.printAllUser();
        }

        private void removeUser_Click(object sender, EventArgs e)
        {
            string user_name = textBoxName.Text;
            string user_surname = textBoxSurname.Text;
            string user_patrnymic = textBoxPatrnymic.Text;
            string user_login = textBoxLogin.Text;
            string user_password = PasswordHasher.HashPassword(textBoxPassword.Text);
            string user_role = comboBoxRole.Text;
            string user_email = textBoxEMail.Text;
            user.removeUSer(
                user_surname,
                user_name,
                user_patrnymic,
                user_login,
                user_password,
                user_role,
                user_email
            );
        }

        private void findUser_Click(object sender, EventArgs e)
        {

        }

        private void addUser_Click(object sender, EventArgs e)
        {
            string user_name = textBoxName.Text;
            string user_surname = textBoxSurname.Text;
            string user_patrnymic = textBoxPatrnymic.Text;
            string user_login = textBoxLogin.Text;
            string user_password = textBoxPassword.Text;
            string user_role = comboBoxRole.Text;
            string user_email = textBoxEMail.Text;
            user.Add_User(
                user_surname,
                user_name,
                user_patrnymic,
                user_login,
                user_password,
                user_role,
                user_email
            );
            try
            {
                SmtpClient smtp = new SmtpClient("smtp.mail.ru");

                smtp.UseDefaultCredentials = true;
                smtp.EnableSsl = true;

                System.Net.NetworkCredential basicAuthenticationInfo = new System.Net.NetworkCredential("sdfgfsgfgdse@mail.ru", "dexXyCreUFSPcC6jckNE");
                smtp.Credentials = basicAuthenticationInfo;

                MailAddress from = new MailAddress("sdfgfsgfgdse@mail.ru", "Admin");
                MailAddress to = new MailAddress(user_email, "User");
                MailMessage message = new System.Net.Mail.MailMessage(from, to);
                message.ReplyToList.Add(from);

                message.Subject = "Password";
                message.SubjectEncoding = System.Text.Encoding.UTF8;

                message.Body = $" Ваш пароль: {user_password}";
                message.BodyEncoding = System.Text.Encoding.UTF8;
                message.IsBodyHtml = true;

                smtp.Send(message);
            }
            catch (SmtpException ex)
            {
                throw new Exception("SMTP Exception has occured" + ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Close();
        }

        private void FormUserAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
