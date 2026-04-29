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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadAdmin();
        }

        private void LoadAdmin()
        {

            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = @"SELECT vehicle_id,name,contact,user_id,vehicle_type,vehicle_model,plate_number FROM owner_approval WHERE ame LIKE @search OR contact LIKE @search OR User_Id LIKE @search OR Vehicle_type LIKE @search OR Vehicle_model LIKE @search OR Plate_Number LIKE @search";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

                System.Data.DataTable table = new System.Data.DataTable();

                adapter.Fill(table);

                dgvHost.DataSource = table;

                dgvHost.Columns["vehicle_id"].HeaderText = "VEHICLE ID";

                dgvHost.Columns["name"].HeaderText = "Name";

                dgvHost.Columns["contact"].HeaderText = "Contact";

                dgvHost.Columns["user_id"].HeaderText = "User ID";

                dgvHost.Columns["vehicle_type"].HeaderText = "Vehicle Type";

                dgvHost.Columns["vehicle_Model"].HeaderText = "Vehicle Model";

                dgvHost.Columns["plate_number"].HeaderText = "Plate Number";



                adapter.Dispose();

                cmd.Dispose();

            }

            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }

            finally
            {

                db.Close();

            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            int Vehicle_ID;


        }

        private void dgvHost_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHost.Rows[e.RowIndex];

                txtFirstName.Text = row.Cells["firstname"].Value.ToString();
                txtLastName.Text = row.Cells["LastName"].Value.ToString();


            }
        }
    }



}
    

