namespace Final_Exams_Act_1D
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
            lblJCLMR = new Label();
            panel2 = new Panel();
            dgvVehicle = new DataGridView();
            btnLogout = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnRequest = new Button();
            btnHost = new Button();
            pictureBox1 = new PictureBox();
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
            lblNote = new Label();
            txtNote = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVehicle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnHost);
            panel1.Controls.Add(btnRequest);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(lblJCLMR);
            panel1.Location = new Point(-5, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1373, 110);
            panel1.TabIndex = 2;
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
            panel2.Size = new Size(717, 531);
            panel2.TabIndex = 15;
            // 
            // dgvVehicle
            // 
            dgvVehicle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehicle.Location = new Point(21, 40);
            dgvVehicle.Name = "dgvVehicle";
            dgvVehicle.RowHeadersWidth = 51;
            dgvVehicle.Size = new Size(666, 470);
            dgvVehicle.TabIndex = 0;
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
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(12, 147);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(465, 32);
            txtSearch.TabIndex = 16;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Teal;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(496, 147);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(233, 32);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnRequest
            // 
            btnRequest.BackColor = Color.Teal;
            btnRequest.FlatAppearance.BorderSize = 0;
            btnRequest.FlatStyle = FlatStyle.Flat;
            btnRequest.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRequest.ForeColor = Color.White;
            btnRequest.Location = new Point(1010, 41);
            btnRequest.Name = "btnRequest";
            btnRequest.Size = new Size(143, 41);
            btnRequest.TabIndex = 17;
            btnRequest.Text = "REQUEST";
            btnRequest.UseVisualStyleBackColor = false;
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
            panel5.Location = new Point(776, 212);
            panel5.Name = "panel5";
            panel5.Size = new Size(387, 223);
            panel5.TabIndex = 22;
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
            panel4.Controls.Add(lblNote);
            panel4.Controls.Add(txtNote);
            panel4.Location = new Point(776, 444);
            panel4.Name = "panel4";
            panel4.Size = new Size(387, 299);
            panel4.TabIndex = 25;
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
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1362, 755);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserDashboard";
            Text = "UserDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVehicle).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblJCLMR;
        private Panel panel2;
        private DataGridView dgvVehicle;
        private Button btnLogout;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnHost;
        private Button btnRequest;
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
        private Panel panel4;
        private Label lblNote;
        private TextBox txtNote;
    }
}