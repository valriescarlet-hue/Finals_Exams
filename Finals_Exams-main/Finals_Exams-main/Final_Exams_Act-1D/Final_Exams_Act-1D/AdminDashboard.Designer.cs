namespace Final_Exams_Act_1D
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnLogout = new Button();
            lblAdmin = new Label();
            panel5 = new Panel();
            lblContact = new Label();
            txtContactNum = new TextBox();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblEmail = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            panel2 = new Panel();
            dgvHost = new DataGridView();
            panel3 = new Panel();
            lblPlateNum = new Label();
            lblModel = new Label();
            lblVehicle = new Label();
            txtPlateNum = new TextBox();
            cmbTypeVehicle = new ComboBox();
            txtModel = new TextBox();
            panel4 = new Panel();
            lblNote = new Label();
            txtNote = new TextBox();
            btnApproved = new Button();
            btnReject = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHost).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(lblAdmin);
            panel1.Location = new Point(-5, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1373, 110);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(38, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 63);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Teal;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(1169, 41);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(143, 41);
            btnLogout.TabIndex = 15;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdmin.ForeColor = Color.White;
            lblAdmin.Location = new Point(560, 30);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(238, 68);
            lblAdmin.TabIndex = 1;
            lblAdmin.Text = "ADMIN";
            lblAdmin.Click += lblAdmin_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.CadetBlue;
            panel5.Controls.Add(lblContact);
            panel5.Controls.Add(txtContactNum);
            panel5.Controls.Add(lblFirstName);
            panel5.Controls.Add(lblLastName);
            panel5.Controls.Add(lblEmail);
            panel5.Controls.Add(txtFirstName);
            panel5.Controls.Add(txtLastName);
            panel5.Controls.Add(txtEmail);
            panel5.Location = new Point(555, 200);
            panel5.Name = "panel5";
            panel5.Size = new Size(387, 223);
            panel5.TabIndex = 21;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new Font("Tahoma", 12F);
            lblContact.Location = new Point(27, 182);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(114, 24);
            lblContact.TabIndex = 12;
            lblContact.Text = "Contact No.";
            // 
            // txtContactNum
            // 
            txtContactNum.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContactNum.Location = new Point(158, 174);
            txtContactNum.Name = "txtContactNum";
            txtContactNum.Size = new Size(187, 32);
            txtContactNum.TabIndex = 11;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = Color.Transparent;
            lblFirstName.Font = new Font("Tahoma", 12F);
            lblFirstName.Location = new Point(27, 25);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(113, 24);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.BackColor = Color.Transparent;
            lblLastName.Font = new Font("Tahoma", 12F);
            lblLastName.Location = new Point(27, 78);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(112, 24);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Last Name:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Tahoma", 12F);
            lblEmail.Location = new Point(27, 126);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(66, 24);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email:";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(158, 17);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(187, 32);
            txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(158, 70);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(187, 32);
            txtLastName.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(158, 118);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(187, 32);
            txtEmail.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CadetBlue;
            panel2.Controls.Add(dgvHost);
            panel2.Location = new Point(21, 200);
            panel2.Name = "panel2";
            panel2.Size = new Size(501, 531);
            panel2.TabIndex = 22;
            // 
            // dgvHost
            // 
            dgvHost.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHost.Location = new Point(21, 25);
            dgvHost.Name = "dgvHost";
            dgvHost.RowHeadersWidth = 51;
            dgvHost.Size = new Size(447, 485);
            dgvHost.TabIndex = 0;
            dgvHost.CellContentClick += dgvHost_CellContentClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.CadetBlue;
            panel3.Controls.Add(lblPlateNum);
            panel3.Controls.Add(lblModel);
            panel3.Controls.Add(lblVehicle);
            panel3.Controls.Add(txtPlateNum);
            panel3.Controls.Add(cmbTypeVehicle);
            panel3.Controls.Add(txtModel);
            panel3.Location = new Point(555, 473);
            panel3.Name = "panel3";
            panel3.Size = new Size(387, 222);
            panel3.TabIndex = 23;
            // 
            // lblPlateNum
            // 
            lblPlateNum.AutoSize = true;
            lblPlateNum.Font = new Font("Tahoma", 12F);
            lblPlateNum.Location = new Point(10, 164);
            lblPlateNum.Name = "lblPlateNum";
            lblPlateNum.Size = new Size(138, 24);
            lblPlateNum.TabIndex = 11;
            lblPlateNum.Text = "Plate Number:";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Tahoma", 12F);
            lblModel.Location = new Point(10, 102);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(70, 24);
            lblModel.TabIndex = 10;
            lblModel.Text = "Model:";
            // 
            // lblVehicle
            // 
            lblVehicle.AutoSize = true;
            lblVehicle.Font = new Font("Tahoma", 12F);
            lblVehicle.Location = new Point(10, 44);
            lblVehicle.Name = "lblVehicle";
            lblVehicle.Size = new Size(131, 24);
            lblVehicle.TabIndex = 9;
            lblVehicle.Text = "Vehicle Type:";
            // 
            // txtPlateNum
            // 
            txtPlateNum.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPlateNum.Location = new Point(158, 156);
            txtPlateNum.Name = "txtPlateNum";
            txtPlateNum.Size = new Size(187, 32);
            txtPlateNum.TabIndex = 8;
            // 
            // cmbTypeVehicle
            // 
            cmbTypeVehicle.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTypeVehicle.FormattingEnabled = true;
            cmbTypeVehicle.Location = new Point(158, 36);
            cmbTypeVehicle.Name = "cmbTypeVehicle";
            cmbTypeVehicle.Size = new Size(187, 32);
            cmbTypeVehicle.TabIndex = 7;
            // 
            // txtModel
            // 
            txtModel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtModel.Location = new Point(158, 94);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(187, 32);
            txtModel.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.CadetBlue;
            panel4.Controls.Add(lblNote);
            panel4.Controls.Add(txtNote);
            panel4.Location = new Point(963, 300);
            panel4.Name = "panel4";
            panel4.Size = new Size(387, 299);
            panel4.TabIndex = 24;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Font = new Font("Tahoma", 12F);
            lblNote.Location = new Point(25, 25);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(59, 24);
            lblNote.TabIndex = 9;
            lblNote.Text = "Note:";
            // 
            // txtNote
            // 
            txtNote.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNote.Location = new Point(25, 70);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(335, 203);
            txtNote.TabIndex = 8;
            // 
            // btnApproved
            // 
            btnApproved.BackColor = Color.Teal;
            btnApproved.FlatAppearance.BorderSize = 0;
            btnApproved.FlatStyle = FlatStyle.Flat;
            btnApproved.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnApproved.ForeColor = Color.White;
            btnApproved.Location = new Point(988, 637);
            btnApproved.Name = "btnApproved";
            btnApproved.Size = new Size(143, 41);
            btnApproved.TabIndex = 25;
            btnApproved.Text = "APPROVE";
            btnApproved.UseVisualStyleBackColor = false;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.Teal;
            btnReject.FlatAppearance.BorderSize = 0;
            btnReject.FlatStyle = FlatStyle.Flat;
            btnReject.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnReject.ForeColor = Color.White;
            btnReject.Location = new Point(1164, 637);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(143, 41);
            btnReject.TabIndex = 26;
            btnReject.Text = "REJECT";
            btnReject.UseVisualStyleBackColor = false;
            btnReject.Click += btnReject_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1362, 755);
            Controls.Add(btnReject);
            Controls.Add(btnApproved);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHost).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblAdmin;
        private Button btnLogout;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Label lblContact;
        private TextBox txtContactNum;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblEmail;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private Panel panel2;
        private DataGridView dgvHost;
        private Panel panel3;
        private Label lblPlateNum;
        private Label lblModel;
        private Label lblVehicle;
        private TextBox txtPlateNum;
        private ComboBox cmbTypeVehicle;
        private TextBox txtModel;
        private Panel panel4;
        private Label lblNote;
        private TextBox txtNote;
        private Button btnApproved;
        private Button btnReject;
    }
}