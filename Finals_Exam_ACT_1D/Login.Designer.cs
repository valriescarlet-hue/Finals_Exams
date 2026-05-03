namespace Finals_Exam_ACT_1D
{
    partial class Login
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
            lblLogin = new Label();
            panel2 = new Panel();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lblPaasword = new Label();
            lblEmail = new Label();
            btnLogin = new Button();
            llblRegister = new LinkLabel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(lblLogin);
            panel1.Location = new Point(-12, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(546, 93);
            panel1.TabIndex = 0;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.White;
            lblLogin.Location = new Point(179, 22);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(184, 55);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "LOGIN";
            lblLogin.Click += lblLogin_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(lblPaasword);
            panel2.Controls.Add(lblEmail);
            panel2.Location = new Point(27, 150);
            panel2.Name = "panel2";
            panel2.Size = new Size(476, 203);
            panel2.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(94, 120);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(355, 46);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(94, 21);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(355, 46);
            txtEmail.TabIndex = 2;
            // 
            // lblPaasword
            // 
            lblPaasword.AutoSize = true;
            lblPaasword.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaasword.ForeColor = Color.White;
            lblPaasword.Location = new Point(16, 136);
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
            lblEmail.Location = new Point(16, 36);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(50, 17);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            lblEmail.Click += lblEmail_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightSlateGray;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(186, 392);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(141, 47);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // llblRegister
            // 
            llblRegister.AutoSize = true;
            llblRegister.Location = new Point(192, 450);
            llblRegister.Name = "llblRegister";
            llblRegister.Size = new Size(137, 15);
            llblRegister.TabIndex = 3;
            llblRegister.TabStop = true;
            llblRegister.Text = "Don't Have An Account?";
            llblRegister.LinkClicked += llblRegister_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(525, 607);
            Controls.Add(llblRegister);
            Controls.Add(btnLogin);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblLogin;
        private Panel panel2;
        private TextBox txtEmail;
        private Label lblPaasword;
        private Label lblEmail;
        private TextBox txtPassword;
        private Button btnLogin;
        private LinkLabel llblRegister;
    }
}