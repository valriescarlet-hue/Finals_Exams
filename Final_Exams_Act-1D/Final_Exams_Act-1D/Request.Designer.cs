namespace Final_Exams_Act_1D
{
    partial class Request
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
            btnHost = new Button();
            btnHome = new Button();
            btnLogout = new Button();
            lblJCLMR = new Label();
            panel2 = new Panel();
            dgvVehicle = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            panel5 = new Panel();
            lblContact = new Label();
            txtContactNum = new TextBox();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblEmail = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            panel4 = new Panel();
            lblPurpose = new Label();
            txtPurpose = new TextBox();
            panel3 = new Panel();
            lblDuration = new Label();
            txtDuration = new TextBox();
            lblLocation = new Label();
            lblDate = new Label();
            lblTime = new Label();
            txtLocation = new TextBox();
            txtDate = new TextBox();
            txtTime = new TextBox();
            btnSendRequest = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicle).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnHost);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(lblJCLMR);
            panel1.Location = new Point(-5, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1373, 110);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(38, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 63);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // btnHost
            // 
            btnHost.BackColor = Color.Teal;
            btnHost.FlatAppearance.BorderSize = 0;
            btnHost.FlatStyle = FlatStyle.Flat;
            btnHost.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnHost.ForeColor = Color.White;
            btnHost.Location = new Point(851, 41);
            btnHost.Name = "btnHost";
            btnHost.Size = new Size(143, 41);
            btnHost.TabIndex = 18;
            btnHost.Text = "HOST";
            btnHost.UseVisualStyleBackColor = false;
            btnHost.Click += btnHost_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Teal;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(1010, 41);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(143, 41);
            btnHome.TabIndex = 17;
            btnHome.Text = "HOME";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
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
            btnLogout.TabIndex = 16;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblJCLMR
            // 
            lblJCLMR.AutoSize = true;
            lblJCLMR.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJCLMR.ForeColor = Color.White;
            lblJCLMR.Location = new Point(560, 30);
            lblJCLMR.Name = "lblJCLMR";
            lblJCLMR.Size = new Size(242, 68);
            lblJCLMR.TabIndex = 1;
            lblJCLMR.Text = "JCLMR";
            // 
            // panel2
            // 
            panel2.BackColor = Color.CadetBlue;
            panel2.Controls.Add(dgvVehicle);
            panel2.Location = new Point(12, 212);
            panel2.Name = "panel2";
            panel2.Size = new Size(501, 531);
            panel2.TabIndex = 23;
            // 
            // dgvVehicle
            // 
            dgvVehicle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicle.Location = new Point(21, 25);
            dgvVehicle.Name = "dgvVehicle";
            dgvVehicle.RowHeadersWidth = 51;
            dgvVehicle.Size = new Size(447, 485);
            dgvVehicle.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(12, 163);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(337, 32);
            txtSearch.TabIndex = 24;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Teal;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(355, 163);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(158, 32);
            btnSearch.TabIndex = 25;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
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
            panel5.Location = new Point(537, 212);
            panel5.Name = "panel5";
            panel5.Size = new Size(387, 223);
            panel5.TabIndex = 26;
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
            // panel4
            // 
            panel4.BackColor = Color.CadetBlue;
            panel4.Controls.Add(lblPurpose);
            panel4.Controls.Add(txtPurpose);
            panel4.Location = new Point(537, 444);
            panel4.Name = "panel4";
            panel4.Size = new Size(387, 299);
            panel4.TabIndex = 27;
            // 
            // lblPurpose
            // 
            lblPurpose.AutoSize = true;
            lblPurpose.Font = new Font("Tahoma", 12F);
            lblPurpose.Location = new Point(25, 25);
            lblPurpose.Name = "lblPurpose";
            lblPurpose.Size = new Size(189, 24);
            lblPurpose.TabIndex = 9;
            lblPurpose.Text = "Purpose of Request:";
            // 
            // txtPurpose
            // 
            txtPurpose.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPurpose.Location = new Point(25, 70);
            txtPurpose.Multiline = true;
            txtPurpose.Name = "txtPurpose";
            txtPurpose.Size = new Size(335, 203);
            txtPurpose.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.CadetBlue;
            panel3.Controls.Add(lblDuration);
            panel3.Controls.Add(txtDuration);
            panel3.Controls.Add(lblLocation);
            panel3.Controls.Add(lblDate);
            panel3.Controls.Add(lblTime);
            panel3.Controls.Add(txtLocation);
            panel3.Controls.Add(txtDate);
            panel3.Controls.Add(txtTime);
            panel3.Location = new Point(952, 212);
            panel3.Name = "panel3";
            panel3.Size = new Size(387, 223);
            panel3.TabIndex = 28;
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Font = new Font("Tahoma", 12F);
            lblDuration.Location = new Point(27, 182);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(94, 24);
            lblDuration.TabIndex = 12;
            lblDuration.Text = "Duration:";
            // 
            // txtDuration
            // 
            txtDuration.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDuration.Location = new Point(158, 174);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(187, 32);
            txtDuration.TabIndex = 11;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.BackColor = Color.Transparent;
            lblLocation.Font = new Font("Tahoma", 12F);
            lblLocation.Location = new Point(27, 25);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(92, 24);
            lblLocation.TabIndex = 3;
            lblLocation.Text = "Location:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Tahoma", 12F);
            lblDate.Location = new Point(27, 78);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(60, 24);
            lblDate.TabIndex = 5;
            lblDate.Text = "Date:";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Tahoma", 12F);
            lblTime.Location = new Point(27, 126);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(62, 24);
            lblTime.TabIndex = 8;
            lblTime.Text = "Time:";
            // 
            // txtLocation
            // 
            txtLocation.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLocation.Location = new Point(158, 17);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(187, 32);
            txtLocation.TabIndex = 4;
            // 
            // txtDate
            // 
            txtDate.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDate.Location = new Point(158, 70);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(187, 32);
            txtDate.TabIndex = 7;
            // 
            // txtTime
            // 
            txtTime.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTime.Location = new Point(158, 118);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(187, 32);
            txtTime.TabIndex = 9;
            // 
            // btnSendRequest
            // 
            btnSendRequest.BackColor = Color.Teal;
            btnSendRequest.FlatAppearance.BorderSize = 0;
            btnSendRequest.FlatStyle = FlatStyle.Flat;
            btnSendRequest.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSendRequest.ForeColor = Color.White;
            btnSendRequest.Location = new Point(1155, 662);
            btnSendRequest.Name = "btnSendRequest";
            btnSendRequest.Size = new Size(184, 60);
            btnSendRequest.TabIndex = 29;
            btnSendRequest.Text = "SEND REQUEST";
            btnSendRequest.UseVisualStyleBackColor = false;
            // 
            // Request
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1362, 755);
            Controls.Add(btnSendRequest);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Request";
            Text = "Request";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVehicle).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnHost;
        private Button btnHome;
        private Button btnLogout;
        private Label lblJCLMR;
        private Panel panel2;
        private DataGridView dgvVehicle;
        private TextBox txtSearch;
        private Button btnSearch;
        private Panel panel5;
        private Label lblContact;
        private TextBox txtContactNum;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblEmail;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private Panel panel4;
        private Label lblPurpose;
        private TextBox txtPurpose;
        private Panel panel3;
        private Label lblDuration;
        private TextBox txtDuration;
        private Label lblLocation;
        private Label lblDate;
        private Label lblTime;
        private TextBox txtLocation;
        private TextBox txtDate;
        private TextBox txtTime;
        private Button btnSendRequest;
    }
}