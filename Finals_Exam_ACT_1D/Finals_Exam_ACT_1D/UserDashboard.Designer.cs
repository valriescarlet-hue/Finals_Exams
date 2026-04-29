namespace Finals_Exam_ACT_1D
{
    partial class UserDashboard
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
            btnRequest = new Button();
            btnLogout = new Button();
            lblJCLMR = new Label();
            panel2 = new Panel();
            dgvVehicle = new DataGridView();
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
            txtSearch = new TextBox();
            btnSearch = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicle).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(btnHost);
            panel1.Controls.Add(btnRequest);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(lblJCLMR);
            panel1.Location = new Point(-5, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1078, 93);
            panel1.TabIndex = 3;
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
            // btnRequest
            // 
            btnRequest.BackColor = Color.LightSlateGray;
            btnRequest.FlatAppearance.BorderSize = 0;
            btnRequest.FlatStyle = FlatStyle.Flat;
            btnRequest.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRequest.ForeColor = Color.White;
            btnRequest.Location = new Point(799, 34);
            btnRequest.Name = "btnRequest";
            btnRequest.Size = new Size(121, 30);
            btnRequest.TabIndex = 4;
            btnRequest.Text = "REQUEST";
            btnRequest.UseVisualStyleBackColor = false;
            btnRequest.Click += btnRequest_Click;
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
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.Controls.Add(dgvVehicle);
            panel2.Location = new Point(12, 190);
            panel2.Name = "panel2";
            panel2.Size = new Size(469, 400);
            panel2.TabIndex = 4;
            // 
            // dgvVehicle
            // 
            dgvVehicle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicle.Location = new Point(16, 17);
            dgvVehicle.Name = "dgvVehicle";
            dgvVehicle.Size = new Size(441, 369);
            dgvVehicle.TabIndex = 0;
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
            panel3.Location = new Point(594, 190);
            panel3.Name = "panel3";
            panel3.Size = new Size(321, 172);
            panel3.TabIndex = 5;
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
            panel4.Location = new Point(594, 368);
            panel4.Name = "panel4";
            panel4.Size = new Size(321, 222);
            panel4.TabIndex = 6;
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
            lblNote.Size = new Size(49, 17);
            lblNote.TabIndex = 9;
            lblNote.Text = "Notel:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 139);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(323, 23);
            txtSearch.TabIndex = 7;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.LightSlateGray;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(368, 139);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(113, 23);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1068, 639);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserDashboard";
            Text = "UserDashboard";
            Load += UserDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVehicle).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnHost;
        private Button btnRequest;
        private Button btnLogout;
        private Label lblJCLMR;
        private Panel panel2;
        private DataGridView dgvVehicle;
        private Panel panel3;
        private Panel panel4;
        private TextBox txtSearch;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private Label lblFirstName;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtContactNum;
        private Label lblContactNum;
        private TextBox txtNote;
        private Label lblNote;
        private Button btnSearch;
    }
}