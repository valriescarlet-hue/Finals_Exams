namespace Finals_Exam_ACT_1D
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
            panel1 = new Panel();
            btnRequest = new Button();
            btnHome = new Button();
            btnLogout = new Button();
            lblJCLMR = new Label();
            panel5 = new Panel();
            txtModel = new TextBox();
            txtVehicleType = new TextBox();
            lblModel = new Label();
            lblVehicleType = new Label();
            txtPlateNum = new TextBox();
            lblPlateNum = new Label();
            btnSendHost = new Button();
            panel4 = new Panel();
            txtNote = new TextBox();
            lblNote = new Label();
            panel3 = new Panel();
            txtContactNum = new TextBox();
            lblContactNum = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            lblFirstName = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(btnRequest);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(lblJCLMR);
            panel1.Location = new Point(-5, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1078, 93);
            panel1.TabIndex = 3;
            // 
            // btnRequest
            // 
            btnRequest.BackColor = Color.LightSlateGray;
            btnRequest.FlatAppearance.BorderSize = 0;
            btnRequest.FlatStyle = FlatStyle.Flat;
            btnRequest.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRequest.ForeColor = Color.White;
            btnRequest.Location = new Point(672, 34);
            btnRequest.Name = "btnRequest";
            btnRequest.Size = new Size(121, 30);
            btnRequest.TabIndex = 5;
            btnRequest.Text = "REQUEST";
            btnRequest.UseVisualStyleBackColor = false;
            btnRequest.Click += btnRequest_Click;
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
            // panel5
            // 
            panel5.BackColor = Color.LightSteelBlue;
            panel5.Controls.Add(txtModel);
            panel5.Controls.Add(txtVehicleType);
            panel5.Controls.Add(lblModel);
            panel5.Controls.Add(lblVehicleType);
            panel5.Controls.Add(txtPlateNum);
            panel5.Controls.Add(lblPlateNum);
            panel5.Location = new Point(201, 314);
            panel5.Name = "panel5";
            panel5.Size = new Size(321, 172);
            panel5.TabIndex = 15;
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
            lblPlateNum.Location = new Point(17, 101);
            lblPlateNum.Name = "lblPlateNum";
            lblPlateNum.Size = new Size(103, 17);
            lblPlateNum.TabIndex = 8;
            lblPlateNum.Text = "Plate Number:";
            // 
            // btnSendHost
            // 
            btnSendHost.BackColor = Color.LightSlateGray;
            btnSendHost.FlatAppearance.BorderSize = 0;
            btnSendHost.FlatStyle = FlatStyle.Flat;
            btnSendHost.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSendHost.ForeColor = Color.White;
            btnSendHost.Location = new Point(731, 488);
            btnSendHost.Name = "btnSendHost";
            btnSendHost.Size = new Size(121, 30);
            btnSendHost.TabIndex = 14;
            btnSendHost.Text = "SEND";
            btnSendHost.UseVisualStyleBackColor = false;
            btnSendHost.Click += btnSendHost_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightSteelBlue;
            panel4.Controls.Add(txtNote);
            panel4.Controls.Add(lblNote);
            panel4.Location = new Point(546, 216);
            panel4.Name = "panel4";
            panel4.Size = new Size(321, 222);
            panel4.TabIndex = 12;
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
            panel3.Location = new Point(201, 121);
            panel3.Name = "panel3";
            panel3.Size = new Size(321, 172);
            panel3.TabIndex = 11;
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
            txtFirstName.Location = new Point(107, 22);
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
            // Host
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1068, 576);
            Controls.Add(panel5);
            Controls.Add(btnSendHost);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Host";
            Text = "Host";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRequest;
        private Button btnHome;
        private Button btnLogout;
        private Label lblJCLMR;
        private Panel panel5;
        private TextBox txtModel;
        private TextBox txtVehicleType;
        private Label lblModel;
        private Label lblVehicleType;
        private TextBox txtPlateNum;
        private Label lblPlateNum;
        private Button btnSendHost;
        private Panel panel4;
        private TextBox txtNote;
        private Label lblNote;
        private Panel panel3;
        private TextBox txtContactNum;
        private Label lblContactNum;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private Label lblFirstName;
        private TextBox txtEmail;
        private Label lblEmail;
    }
}