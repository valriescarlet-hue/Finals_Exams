namespace Finals_Exam_ACT_1D
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
            btnLogout = new Button();
            lblADMIN = new Label();
            panel2 = new Panel();
            dgvHost = new DataGridView();
            panel3 = new Panel();
            txtContactNum = new TextBox();
            lblContactNum = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            lblFirstName = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            panel4 = new Panel();
            txtNote = new TextBox();
            lblNote = new Label();
            btnApprove = new Button();
            btnReject = new Button();
            panel5 = new Panel();
            txtVehicleID = new TextBox();
            lblVehicleId = new Label();
            txtModel = new TextBox();
            txtVehicleType = new TextBox();
            lblModel = new Label();
            lblVehicleType = new Label();
            txtPlateNum = new TextBox();
            lblPlateNum = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHost).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(lblADMIN);
            panel1.Location = new Point(-5, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1078, 93);
            panel1.TabIndex = 3;
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
            btnLogout.Click += btnLogout_Click_1;
            // 
            // lblADMIN
            // 
            lblADMIN.AutoSize = true;
            lblADMIN.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblADMIN.ForeColor = Color.White;
            lblADMIN.Location = new Point(421, 23);
            lblADMIN.Name = "lblADMIN";
            lblADMIN.Size = new Size(193, 55);
            lblADMIN.TabIndex = 0;
            lblADMIN.Text = "ADMIN";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.Controls.Add(dgvHost);
            panel2.Location = new Point(12, 171);
            panel2.Name = "panel2";
            panel2.Size = new Size(347, 411);
            panel2.TabIndex = 4;
            // 
            // dgvHost
            // 
            dgvHost.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHost.Location = new Point(8, 14);
            dgvHost.Name = "dgvHost";
            dgvHost.Size = new Size(332, 383);
            dgvHost.TabIndex = 0;
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
            panel3.Location = new Point(376, 171);
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
            // panel4
            // 
            panel4.BackColor = Color.LightSteelBlue;
            panel4.Controls.Add(txtNote);
            panel4.Controls.Add(lblNote);
            panel4.Location = new Point(721, 266);
            panel4.Name = "panel4";
            panel4.Size = new Size(321, 222);
            panel4.TabIndex = 7;
            // 
            // txtNote
            // 
            txtNote.Location = new Point(17, 52);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(289, 156);
            txtNote.TabIndex = 16;
            txtNote.UseSystemPasswordChar = true;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNote.ForeColor = Color.White;
            lblNote.Location = new Point(17, 22);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(45, 17);
            lblNote.TabIndex = 9;
            lblNote.Text = "Note:";
            // 
            // btnApprove
            // 
            btnApprove.BackColor = Color.LightSlateGray;
            btnApprove.FlatAppearance.BorderSize = 0;
            btnApprove.FlatStyle = FlatStyle.Flat;
            btnApprove.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApprove.ForeColor = Color.White;
            btnApprove.Location = new Point(738, 538);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(121, 30);
            btnApprove.TabIndex = 8;
            btnApprove.Text = "APPROVE";
            btnApprove.UseVisualStyleBackColor = false;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnReject
            // 
            btnReject.BackColor = Color.LightSlateGray;
            btnReject.FlatAppearance.BorderSize = 0;
            btnReject.FlatStyle = FlatStyle.Flat;
            btnReject.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReject.ForeColor = Color.White;
            btnReject.Location = new Point(906, 538);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(121, 30);
            btnReject.TabIndex = 9;
            btnReject.Text = "REJECT";
            btnReject.UseVisualStyleBackColor = false;
            btnReject.Click += btnReject_Click_1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightSteelBlue;
            panel5.Controls.Add(txtVehicleID);
            panel5.Controls.Add(lblVehicleId);
            panel5.Controls.Add(txtModel);
            panel5.Controls.Add(txtVehicleType);
            panel5.Controls.Add(lblModel);
            panel5.Controls.Add(lblVehicleType);
            panel5.Controls.Add(txtPlateNum);
            panel5.Controls.Add(lblPlateNum);
            panel5.Location = new Point(376, 364);
            panel5.Name = "panel5";
            panel5.Size = new Size(321, 172);
            panel5.TabIndex = 10;
            // 
            // txtVehicleID
            // 
            txtVehicleID.Location = new Point(126, 135);
            txtVehicleID.Name = "txtVehicleID";
            txtVehicleID.Size = new Size(180, 23);
            txtVehicleID.TabIndex = 15;
            // 
            // lblVehicleId
            // 
            lblVehicleId.AutoSize = true;
            lblVehicleId.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVehicleId.ForeColor = Color.White;
            lblVehicleId.Location = new Point(9, 141);
            lblVehicleId.Name = "lblVehicleId";
            lblVehicleId.Size = new Size(75, 17);
            lblVehicleId.TabIndex = 14;
            lblVehicleId.Text = "vehicle_id";
            // 
            // txtModel
            // 
            txtModel.Location = new Point(126, 56);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(180, 23);
            txtModel.TabIndex = 13;
            // 
            // txtVehicleType
            // 
            txtVehicleType.Location = new Point(126, 17);
            txtVehicleType.Name = "txtVehicleType";
            txtVehicleType.Size = new Size(180, 23);
            txtVehicleType.TabIndex = 12;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModel.ForeColor = Color.White;
            lblModel.Location = new Point(17, 57);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(56, 17);
            lblModel.TabIndex = 11;
            lblModel.Text = "Model:";
            // 
            // lblVehicleType
            // 
            lblVehicleType.AutoSize = true;
            lblVehicleType.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVehicleType.ForeColor = Color.White;
            lblVehicleType.Location = new Point(15, 23);
            lblVehicleType.Name = "lblVehicleType";
            lblVehicleType.Size = new Size(97, 17);
            lblVehicleType.TabIndex = 10;
            lblVehicleType.Text = "Vehicle Type:";
            // 
            // txtPlateNum
            // 
            txtPlateNum.Location = new Point(126, 95);
            txtPlateNum.Name = "txtPlateNum";
            txtPlateNum.Size = new Size(180, 23);
            txtPlateNum.TabIndex = 9;
            // 
            // lblPlateNum
            // 
            lblPlateNum.AutoSize = true;
            lblPlateNum.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlateNum.ForeColor = Color.White;
            lblPlateNum.Location = new Point(9, 101);
            lblPlateNum.Name = "lblPlateNum";
            lblPlateNum.Size = new Size(103, 17);
            lblPlateNum.TabIndex = 8;
            lblPlateNum.Text = "Plate Number:";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1068, 639);
            Controls.Add(panel5);
            Controls.Add(btnReject);
            Controls.Add(btnApprove);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHost).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLogout;
        private Label lblADMIN;
        private Panel panel2;
        private DataGridView dgvHost;
        private Panel panel3;
        private TextBox txtContactNum;
        private Label lblContactNum;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private Label lblFirstName;
        private TextBox txtEmail;
        private Label lblEmail;
        private Panel panel4;
        private TextBox txtNote;
        private Label lblNote;
        private Button btnApprove;
        private Button btnReject;
        private Panel panel5;
        private TextBox txtModel;
        private TextBox txtVehicleType;
        private Label lblModel;
        private Label lblVehicleType;
        private TextBox txtPlateNum;
        private Label lblPlateNum;
        private TextBox txtVehicleID;
        private Label lblVehicleId;
    }
}