using Final_Exam_Act_1D;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals_Exam_ACT_1D
{
    public partial class Request : Form
    {
        public Request()
        {
            InitializeComponent();
        }

        private void btnHost_Click(object sender, EventArgs e)
        {
            Host host = new Host();
            host.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UserDashboard userDashboard = new UserDashboard();
            userDashboard.Show();
            this.Hide();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnSendRequest_Click(object sender, EventArgs e)
        {
            string firstname = txtFirstName.Text.Trim();
            string lastname = txtLastName.Text.Trim();
            string contactnum = txtContactNum.Text.Trim();
            string email = txtEmail.Text.Trim();
            string location = txtLocation.Text.Trim();
            string time = txtTime.Text.Trim();
            string date = txtDate.Text.Trim();


            if (string.IsNullOrEmpty(date) || string.IsNullOrEmpty(time) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(location) || string.IsNullOrEmpty(contactnum) ||
                string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname))
            {
                MessageBox.Show("Please fill all Fields!");
                return;
            }

            DBConnect db = new DBConnect();

            try
            {
                db.Open();

                string query = "INSERT INTO owner_approval (name, contact, vehicle_type, vehicle_model, plate_number)" + "VALUES (@firstname, @contactnum, @vehicletype, @model, @platenum)";

                MySql.Data.MySqlClient.MySqlCommand cmd =
                    new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadVehicle();
        }



        private void LoadVehicle()
        {
            string search = txtSearch.Text.Trim();



            DBConnect db = new DBConnect();

            try

            {

                db.Open();

                string query = @"SELECT vehicle_id, Name, contact, User_Id, Vehicle_type, Vehicle_model, Plate_number, availability FROM vehicles WHERE Name LIKE @search OR contact LIKE @search OR User_Id LIKE @search OR Vehicle_type LIKE @search OR Vehicle_model LIKE @search OR Plate_Number LIKE @search OR availability LIKE @availability";



                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@search", "%" + search + "%");



                MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

                System.Data.DataTable table = new System.Data.DataTable();

                adapter.Fill(table);

                dgvVehicle.DataSource = table;



                dgvVehicle.Columns["vehicle_id"].HeaderText = "VEHICLE ID";

                dgvVehicle.Columns["namw"].HeaderText = "Name";

                dgvVehicle.Columns["contact"].HeaderText = "Contact";

                dgvVehicle.Columns["user_id"].HeaderText = "User ID";

                dgvVehicle.Columns["vehicle_type"].HeaderText = "Vehicle Type";

                dgvVehicle.Columns["vehicle_Model"].HeaderText = "Vehicle Model";

                dgvVehicle.Columns["plate_number"].HeaderText = "Plate Number";

                dgvVehicle.Columns["availability"].HeaderText = "Availability";



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

        private void dgvVehicle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvVehicle.Rows[e.RowIndex];

            txtFirstName.Text = row.Cells["firstname"].Value.ToString();
                txtLastName.Text = row.Cells["LastName"].Value.ToString();
                txtContactNum.Text = row.Cells["ContactNum"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtLocation.Text = row.Cells["location"].Value.ToString();
                txtPurpose.Text = row.Cells["Purpose"].Value.ToString();
                txtTime.Text = row.Cells["time"].Value.ToString();
                txtDate.Text = row.Cells["date"].Value.ToString();

            } 
        }
    }
}
