namespace Finals_Exam_ACT_1D
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
            btnHost = new Button();
            btnHome = new Button();
            btnLogout = new Button();
            lblJCLMR = new Label();
            panel3 = new Panel();
            txtContactNum = new TextBox();
            lblContactNum = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            lblFirstName = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            panel2 = new Panel();
            dgvVehicle = new DataGridView();
            btnSearch = new Button();
            txtSearch = new TextBox();
            panel4 = new Panel();
            txtPurpose = new TextBox();
            lblPurpose = new Label();
            panel5 = new Panel();
            txtDate = new TextBox();
            txtLocation = new TextBox();
            lblDate = new Label();
            lblLocation = new Label();
            txtTime = new TextBox();
            lblTime = new Label();
            btnSendRequest = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicle).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(btnHost);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(lblJCLMR);
            panel1.Location = new Point(-5, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1078, 93);
            panel1.TabIndex = 2;
            // 
            // btnHost
            // 
            btnHost.BackColor = Color.LightSlateGray;
            btnHost.FlatAppearance.BorderSize = 0;
            btnHost.FlatStyle = FlatStyle.Flat;
            btnHost.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHost.ForeColor = Color.White;
            btnHost.Location = new Point(672, 34);
            btnHost.Name = "btnHost";
            btnHost.Size = new Size(121, 30);
            btnHost.TabIndex = 5;
            btnHost.Text = "HOST";
            btnHost.UseVisualStyleBackColor = false;
            btnHost.Click += btnHost_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.LightSlateGray;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(799, 34);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(121, 30);
            btnHome.TabIndex = 4;
            btnHome.Text = "HOME";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.LightSlateGray;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(926, 34);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(121, 30);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblJCLMR
            // 
            lblJCLMR.AutoSize = true;
            lblJCLMR.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJCLMR.ForeColor = Color.White;
            lblJCLMR.Location = new Point(421, 23);
            lblJCLMR.Name = "lblJCLMR";
            lblJCLMR.Size = new Size(195, 55);
            lblJCLMR.TabIndex = 0;
            lblJCLMR.Text = "JCLMR";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSteelBlue;
            panel3.Controls.Add(txtContactNum);
            panel3.Controls.Add(lblContactNum);
            panel3.Controls.Add(txtLastName);
            panel3.Controls.Add(txtFirstName);
            panel3.Controls.Add(lblLastName);
            panel3.Controls.Add(lblFirstName);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(lblEmail);
            panel3.Location = new Point(442, 195);
            panel3.Name = "panel3";
            panel3.Size = new Size(321, 172);
            panel3.TabIndex = 6;
            // 
            // txtContactNum
            // 
            txtContactNum.Location = new Point(107, 129);
            txtContactNum.Name = "txtContactNum";
            txtContactNum.Size = new Size(199, 23);
            txtContactNum.TabIndex = 15;
            txtContactNum.UseSystemPasswordChar = true;
            // 
            // lblContactNum
            // 
            lblContactNum.AutoSize = true;
            lblContactNum.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContactNum.ForeColor = Color.White;
            lblContactNum.Location = new Point(14, 135);
            lblContactNum.Name = "lblContactNum";
            lblContactNum.Size = new Size(87, 17);
            lblContactNum.TabIndex = 14;
            lblContactNum.Text = "Contact No:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(107, 56);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(199, 23);
            txtLastName.TabIndex = 13;
            txtLastName.UseSystemPasswordChar = true;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(107, 17);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(199, 23);
            txtFirstName.TabIndex = 12;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.ForeColor = Color.White;
            lblLastName.Location = new Point(17, 57);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(84, 17);
            lblLastName.TabIndex = 11;
            lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.ForeColor = Color.White;
            lblFirstName.Location = new Point(15, 23);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(86, 17);
            lblFirstName.TabIndex = 10;
            lblFirstName.Text = "First Name:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(107, 95);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(199, 23);
            txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(17, 101);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(50, 17);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.Controls.Add(dgvVehicle);
            panel2.Location = new Point(12, 195);
            panel2.Name = "panel2";
            panel2.Size = new Size(398, 418);
            panel2.TabIndex = 7;
            // 
            // dgvVehicle
            // 
            dgvVehicle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicle.Location = new Point(16, 17);
            dgvVehicle.Name = "dgvVehicle";
            dgvVehicle.Size = new Size(366, 386);
            dgvVehicle.TabIndex = 0;
            dgvVehicle.CellContentClick += dgvVehicle_CellContentClick;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightSlateGray;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(297, 145);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(113, 23);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 145);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(279, 23);
            txtSearch.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightSteelBlue;
            panel4.Controls.Add(txtPurpose);
            panel4.Controls.Add(lblPurpose);
            panel4.Location = new Point(442, 391);
            panel4.Name = "panel4";
            panel4.Size = new Size(321, 222);
            panel4.TabIndex = 11;
            // 
            // txtPurpose
            // 
            txtPurpose.Location = new Point(17, 52);
            txtPurpose.Multiline = true;
            txtPurpose.Name = "txtPurpose";
            txtPurpose.Size = new Size(289, 156);
            txtPurpose.TabIndex = 16;
            txtPurpose.UseSystemPasswordChar = true;
            // 
            // lblPurpose
            // 
            lblPurpose.AutoSize = true;
            lblPurpose.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPurpose.ForeColor = Color.White;
            lblPurpose.Location = new Point(17, 22);
            lblPurpose.Name = "lblPurpose";
            lblPurpose.Size = new Size(142, 17);
            lblPurpose.TabIndex = 9;
            lblPurpose.Text = "Purpose of Request:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightSteelBlue;
            panel5.Controls.Add(txtDate);
            panel5.Controls.Add(txtLocation);
            panel5.Controls.Add(lblDate);
            panel5.Controls.Add(lblLocation);
            panel5.Controls.Add(txtTime);
            panel5.Controls.Add(lblTime);
            panel5.Location = new Point(769, 324);
            panel5.Name = "panel5";
            panel5.Size = new Size(287, 139);
            panel5.TabIndex = 12;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(107, 56);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(166, 23);
            txtDate.TabIndex = 13;
            txtDate.UseSystemPasswordChar = true;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(107, 17);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(166, 23);
            txtLocation.TabIndex = 12;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(17, 62);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(44, 17);
            lblDate.TabIndex = 11;
            lblDate.Text = "Date:";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocation.ForeColor = Color.White;
            lblLocation.Location = new Point(15, 23);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(70, 17);
            lblLocation.TabIndex = 10;
            lblLocation.Text = "Location:";
            // 
            // txtTime
            // 
            txtTime.Location = new Point(107, 95);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(166, 23);
            txtTime.TabIndex = 9;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(17, 101);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(47, 17);
            lblTime.TabIndex = 8;
            lblTime.Text = "Time:";
            // 
            // btnSendRequest
            // 
            btnSendRequest.BackColor = Color.LightSlateGray;
            btnSendRequest.FlatAppearance.BorderSize = 0;
            btnSendRequest.FlatStyle = FlatStyle.Flat;
            btnSendRequest.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSendRequest.ForeColor = Color.White;
            btnSendRequest.Location = new Point(876, 549);
            btnSendRequest.Name = "btnSendRequest";
            btnSendRequest.Size = new Size(121, 30);
            btnSendRequest.TabIndex = 13;
            btnSendRequest.Text = "SEND";
            btnSendRequest.UseVisualStyleBackColor = false;
            btnSendRequest.Click += btnSendRequest_Click;
            // 
            // Request
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1068, 639);
            Controls.Add(btnSendRequest);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Request";
            Text = "Request";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVehicle).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblJCLMR;
        private Button btnLogout;
        private Button btnHost;
        private Button btnHome;
        private Panel panel3;
        private TextBox txtContactNum;
        private Label lblContactNum;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private Label lblFirstName;
        private TextBox txtEmail;
        private Label lblEmail;
        private Panel panel2;
        private DataGridView dgvVehicle;
        private Button btnSearch;
        private TextBox txtSearch;
        private Panel panel4;
        private TextBox txtPurpose;
        private Label lblPurpose;
        private Panel panel5;
        private TextBox txtDate;
        private TextBox txtLocation;
        private Label lblDate;
        private Label lblLocation;
        private TextBox txtTime;
        private Label lblTime;
        private Button btnSendRequest;
    }
}