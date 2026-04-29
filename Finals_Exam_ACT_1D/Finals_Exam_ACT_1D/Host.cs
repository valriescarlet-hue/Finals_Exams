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
    public partial class Host : Form
    {
        public Host()
        {
            InitializeComponent();
        }

        private void btnSendHost_Click(object sender, EventArgs e)
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

                string query = "INSERT INTO owner_approval (name, contact, vehicle_type, vehicle_model, plate_number)" + "VALUES (@firstname, @contactnum, @vehicletype, @model, @platenum)";

                MySql.Data.MySqlClient.MySqlCommand cmd =
                    new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

            finally { db.Close(); 
               }
    }

    }
}
