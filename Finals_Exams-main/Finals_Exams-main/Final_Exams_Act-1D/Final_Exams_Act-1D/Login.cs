using Final_Exam_Act_1D;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final_Exams_Act_1D
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (email == "" || password == "")
            {
                MessageBox.Show("Please enter Email and Password.");
                return;
            }

            DBConnect db = new DBConnect();

            try
            {
                db.Open();
                string query = "SELECT COUNT(*) FROM users WHERE email=@email AND password=@password";

                MySql.Data.MySqlClient.MySqlCommand cmd =
                    new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();

                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");

                    if (email == "admin")
                    {
                        AdminDashboard adminDashboard = new AdminDashboard();
                        adminDashboard.Show();
                        this.Hide();
                    }

                    else
                    {
                        UserDashboard userDashboard = new UserDashboard();
                        userDashboard.Show();
                        this.Hide();
                    }

                }

                else
                {
                    MessageBox.Show("Invalid Email or Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.Close();
            }

        }

        private void llblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
