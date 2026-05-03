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
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            LoadVehicle();

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

        private void LoadVehicle()
        {
            string search = txtSearch.Text.Trim();



            DBConnect db = new DBConnect();

            try

            {

                db.Open();

                string query = @"SELECT vehicle_id, first_name,last_name  contact, User_Id, Vehicle_type, Vehicle_model, Plate_number, availability FROM vehicle WHERE first_name LIKE @search OR last_name LIKE @search ORcontact LIKE @search OR User_Id LIKE @search OR Vehicle_type LIKE @search OR Vehicle_model LIKE @search OR Plate_Number LIKE @search OR availability LIKE @availability";



                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@search", "%" + search + "%");



                MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd);

                System.Data.DataTable table = new System.Data.DataTable();

                adapter.Fill(table);

                dgvVehicle.DataSource = table;



                dgvVehicle.Columns["vehicle_id"].HeaderText = "VEHICLE ID";

                dgvVehicle.Columns["first_name"].HeaderText = "first name";

                dgvVehicle.Columns["last_name"].HeaderText = "last name";

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


        private void dgvVehicle_CellClick(object sender, DataGridViewCellEventArgs e)

        {

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
                txtNote.Text = row.Cells["Note"].Value.ToString();
            }

        }
    }
}
