using Final_Exam_Act_1D;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals_Exam_ACT_1D
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
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

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {

            string firstname = txtFirstName.Text.Trim();
            string lastname = txtLastName.Text.Trim();
            string contactnum = txtContactNum.Text.Trim();
            string email = txtEmail.Text.Trim();
            string vehicletype = txtVehicleType.Text.Trim();
            string model = txtModel.Text.Trim();
            string platenum = txtPlateNum.Text.Trim();
            string note = txtNote.Text.Trim();

            if (string.IsNullOrEmpty(firstname) || string.IsNullOrEmpty(lastname) || string.IsNullOrEmpty(contactnum) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(vehicletype) || string.IsNullOrEmpty(model) || string.IsNullOrEmpty(platenum) || string.IsNullOrEmpty(note))
            {
                MessageBox.Show("Please fill all Fields!");
                return;
            }

            DBConnect db = new DBConnect();

            try
            {
                db.Open();


                string query = "INSERT INTO vehicle (name, contact, vehicle_type, vehicle_model, plate_number)" + "VALUES (@firstname, @contactnum, @vehicletype, @model, @platenum)";
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

        private void btnReject_Click_1(object sender, EventArgs e)
        {

            int vehicle_id;

            if (int.TryParse(txtVehicleID.Text, out vehicle_id))
            {
                return;
            }

            DBConnect db = new DBConnect();
            try
            {
                db.Open();

                string query = "DELETE FROM owner_approval WHERE vehicle_id=@vehicle_id";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@vehicle_id", vehicle_id);

                cmd.ExecuteNonQuery();

                cmd.Dispose();

                MessageBox.Show("sucessfully deleted!");

                txtContactNum.Clear();
                txtEmail.Clear();
                txtFirstName.Clear();
                txtLastName.Clear();
                txtModel.Clear();
                txtNote.Clear();
                txtPlateNum.Clear();
                txtVehicleID.Clear();
                txtVehicleType.Clear();

            }
            catch(Exception ex)
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
    


