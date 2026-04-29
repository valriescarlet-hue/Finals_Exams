using Final_Exam_Act_1D;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals_Exam_ACT_1D
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void llblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string firstname = txtFirstName.Text.Trim();
            string lastname = txtLastName.Text.Trim();
            string contactnum = txtContactNum.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
         

            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(contactnum)
                || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill up the form");
                return;

            }

            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = "INSERT INTO user (firstname,lastname,contactnum,email,password)" + "VALUES (@first_name,@last_name," +
                    "@contact,@email,@password)";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);


                cmd.Parameters.AddWithValue("@first_name", firstname);
                cmd.Parameters.AddWithValue("@last_name", lastname);
                cmd.Parameters.AddWithValue("@contact", contactnum);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);


                cmd.ExecuteNonQuery();

                MessageBox.Show("you have been sucessfully added to ther system!");

                txtFirstName.Clear();
                txtLastName.Clear();
                txtContactNum.Clear();
                txtEmail.Clear();
                txtPassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            finally
            {
                db.Close();
            }
        }
    }
}
