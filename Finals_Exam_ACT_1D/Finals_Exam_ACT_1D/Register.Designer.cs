namespace Finals_Exam_ACT_1D
{
    partial class Register
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
            lblRegister = new Label();
            llblRegister = new LinkLabel();
            btnRegister = new Button();
            panel2 = new Panel();
            txtContactNum = new TextBox();
            lblContactNum = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            lblFirstName = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lblPaasword = new Label();
            lblEmail = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(lblRegister);
            panel1.Location = new Point(-5, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(546, 93);
            panel1.TabIndex = 1;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegister.ForeColor = Color.White;
            lblRegister.Location = new Point(139, 24);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(273, 55);
            lblRegister.TabIndex = 0;
            lblRegister.Text = "REGISTER";
            // 
            // llblRegister
            // 
            llblRegister.AutoSize = true;
            llblRegister.Location = new Point(196, 477);
            llblRegister.Name = "llblRegister";
            llblRegister.Size = new Size(144, 15);
            llblRegister.TabIndex = 6;
            llblRegister.TabStop = true;
            llblRegister.Text = "Already have an Account?";
            llblRegister.LinkClicked += llblRegister_LinkClicked;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.LightSlateGray;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(196, 418);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(141, 47);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.Controls.Add(txtContactNum);
            panel2.Controls.Add(lblContactNum);
            panel2.Controls.Add(txtLastName);
            panel2.Controls.Add(txtFirstName);
            panel2.Controls.Add(lblLastName);
            panel2.Controls.Add(lblFirstName);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(lblPaasword);
            panel2.Controls.Add(lblEmail);
            panel2.Location = new Point(109, 123);
            panel2.Name = "panel2";
            panel2.Size = new Size(324, 261);
            panel2.TabIndex = 4;
            // 
            // txtContactNum
            // 
            txtContactNum.Location = new Point(104, 143);
            txtContactNum.Name = "txtContactNum";
            txtContactNum.Size = new Size(199, 23);
            txtContactNum.TabIndex = 9;
            txtContactNum.UseSystemPasswordChar = true;
            // 
            // lblContactNum
            // 
            lblContactNum.AutoSize = true;
            lblContactNum.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContactNum.ForeColor = Color.White;
            lblContactNum.Location = new Point(11, 149);
            lblContactNum.Name = "lblContactNum";
            lblContactNum.Size = new Size(87, 17);
            lblContactNum.TabIndex = 8;
            lblContactNum.Text = "Contact No:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(103, 66);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(199, 23);
            txtLastName.TabIndex = 7;
            txtLastName.UseSystemPasswordChar = true;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(103, 27);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(199, 23);
            txtFirstName.TabIndex = 6;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.ForeColor = Color.White;
            lblLastName.Location = new Point(13, 67);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(84, 17);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Last Name:";
            lblLastName.Click += lblLastName_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.ForeColor = Color.White;
            lblFirstName.Location = new Point(11, 33);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(86, 17);
            lblFirstName.TabIndex = 4;
            lblFirstName.Text = "First Name:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(104, 179);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(199, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(103, 105);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(199, 23);
            txtEmail.TabIndex = 2;
            // 
            // lblPaasword
            // 
            lblPaasword.AutoSize = true;
            lblPaasword.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaasword.ForeColor = Color.White;
            lblPaasword.Location = new Point(13, 185);
            lblPaasword.Name = "lblPaasword";
            lblPaasword.Size = new Size(75, 17);
            lblPaasword.TabIndex = 1;
            lblPaasword.Text = "Password:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(13, 111);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(50, 17);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            lblEmail.Click += lblEmail_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(538, 560);
            Controls.Add(llblRegister);
            Controls.Add(btnRegister);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Register";
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblRegister;
        private LinkLabel llblRegister;
        private Button btnRegister;
        private Panel panel2;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblPaasword;
        private Label lblEmail;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private Label lblFirstName;
        private TextBox txtContactNum;
        private Label lblContactNum;
    }
}