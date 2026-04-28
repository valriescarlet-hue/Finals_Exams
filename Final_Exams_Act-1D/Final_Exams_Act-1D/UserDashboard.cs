using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final_Exams_Act_1D
{
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnHost_Click(object sender, EventArgs e)
        {
            Host host = new Host();
            host.Show();
            this.Hide();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            Request request = new Request();
            request.Show();
            this.Hide();
        }
    }
}
