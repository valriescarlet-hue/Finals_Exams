namespace Final_Exams_Act_1D
{
    partial class Host
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
            txtModel = new TextBox();
            cmbTypeVehicle = new ComboBox();
            panel2 = new Panel();
            lblPlateNum = new Label();
            lblModel = new Label();
            lblVehicle = new Label();
            txtPlateNum = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnHome = new Button();
            btnRequest = new Button();
            btnLogout = new Button();
            lblJCLMR = new Label();
            panel5 = new Panel();
            lblContact = new Label();
            txtContactNum = new TextBox();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblEmail = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            panel3 = new Panel();
            lblNote = new Label();
            txtNote = new TextBox();
            btnSendHost = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtModel
            // 
            txtModel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtModel.Location = new Point(158, 94);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(187, 32);
            txtModel.TabIndex = 6;
            txtModel.TextChanged += txtModel_TextChanged;
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
            // panel2
            // 
            panel2.BackColor = Color.CadetBlue;
            panel2.Controls.Add(lblPlateNum);
            panel2.Controls.Add(lblModel);
            panel2.Controls.Add(lblVehicle);
            panel2.Controls.Add(txtPlateNum);
            panel2.Controls.Add(cmbTypeVehicle);
            panel2.Controls.Add(txtModel);
            panel2.Location = new Point(33, 402);
            panel2.Name = "panel2";
            panel2.Size = new Size(387, 222);
            panel2.TabIndex = 14;
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
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(btnRequest);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(lblJCLMR);
            panel1.Location = new Point(-5, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1053, 111);
            panel1.TabIndex = 17;
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
            // btnHome
            // 
            btnHome.BackColor = Color.Teal;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(575, 41);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(143, 41);
            btnHome.TabIndex = 18;
            btnHome.Text = "HOME";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // btnRequest
            // 
            btnRequest.BackColor = Color.Teal;
            btnRequest.FlatAppearance.BorderSize = 0;
            btnRequest.FlatStyle = FlatStyle.Flat;
            btnRequest.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRequest.ForeColor = Color.White;
            btnRequest.Location = new Point(739, 41);
            btnRequest.Name = "btnRequest";
            btnRequest.Size = new Size(143, 41);
            btnRequest.TabIndex = 17;
            btnRequest.Text = "REQUEST";
            btnRequest.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Teal;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(888, 41);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(143, 41);
            btnLogout.TabIndex = 16;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // lblJCLMR
            // 
            lblJCLMR.AutoSize = true;
            lblJCLMR.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJCLMR.ForeColor = Color.White;
            lblJCLMR.Location = new Point(255, 30);
            lblJCLMR.Name = "lblJCLMR";
            lblJCLMR.Size = new Size(242, 68);
            lblJCLMR.TabIndex = 1;
            lblJCLMR.Text = "JCLMR";
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
            panel5.Location = new Point(33, 144);
            panel5.Name = "panel5";
            panel5.Size = new Size(387, 223);
            panel5.TabIndex = 20;
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
            // panel3
            // 
            panel3.BackColor = Color.CadetBlue;
            panel3.Controls.Add(lblNote);
            panel3.Controls.Add(txtNote);
            panel3.Location = new Point(490, 229);
            panel3.Name = "panel3";
            panel3.Size = new Size(387, 299);
            panel3.TabIndex = 21;
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
            // btnSendHost
            // 
            btnSendHost.BackColor = Color.Teal;
            btnSendHost.FlatAppearance.BorderSize = 0;
            btnSendHost.FlatStyle = FlatStyle.Flat;
            btnSendHost.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSendHost.ForeColor = Color.White;
            btnSendHost.Location = new Point(734, 583);
            btnSendHost.Name = "btnSendHost";
            btnSendHost.Size = new Size(143, 41);
            btnSendHost.TabIndex = 22;
            btnSendHost.Text = "SEND";
            btnSendHost.UseVisualStyleBackColor = false;
            btnSendHost.Click += btnSendHost_Click;
            // 
            // Host
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1044, 755);
            Controls.Add(btnSendHost);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Host";
            Text = "Host";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtModel;
        private ComboBox cmbTypeVehicle;
        private Panel panel2;
        private Panel panel1;
        private Button btnHome;
        private Button btnRequest;
        private Button btnLogout;
        private Label lblJCLMR;
        private PictureBox pictureBox1;
        private TextBox txtPlateNum;
        private Label lblPlateNum;
        private Label lblModel;
        private Label lblVehicle;
        private Panel panel5;
        private Label lblContact;
        private TextBox txtContactNum;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblEmail;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private Panel panel3;
        private Label lblNote;
        private TextBox txtNote;
        private Button btnSendHost;
    }
}