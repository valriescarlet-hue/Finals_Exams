namespace Final_Exams_Act_1D
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
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            panel2 = new Panel();
            btnLogin = new Button();
            llblRegister = new LinkLabel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblLogin);
            panel1.Location = new Point(-5, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(729, 166);
            panel1.TabIndex = 0;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.White;
            lblLogin.Location = new Point(194, 87);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(228, 68);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "LOGIN";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(203, 270);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(187, 32);
            txtEmail.TabIndex = 5;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Tahoma", 12F);
            lblEmail.Location = new Point(86, 278);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(66, 24);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(203, 320);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(187, 32);
            txtPassword.TabIndex = 11;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Tahoma", 12F);
            lblPassword.Location = new Point(86, 328);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(101, 24);
            lblPassword.TabIndex = 12;
            lblPassword.Text = "Password:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.CadetBlue;
            panel2.Location = new Point(-18, 496);
            panel2.Name = "panel2";
            panel2.Size = new Size(654, 128);
            panel2.TabIndex = 13;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.CadetBlue;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(203, 377);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(187, 41);
            btnLogin.TabIndex = 14;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // llblRegister
            // 
            llblRegister.ActiveLinkColor = Color.DarkSlateGray;
            llblRegister.AutoSize = true;
            llblRegister.Font = new Font("Tahoma", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            llblRegister.LinkColor = Color.DarkSlateGray;
            llblRegister.Location = new Point(189, 421);
            llblRegister.Name = "llblRegister";
            llblRegister.Size = new Size(219, 24);
            llblRegister.TabIndex = 19;
            llblRegister.TabStop = true;
            llblRegister.Text = "Don't have an Account?";
            llblRegister.VisitedLinkColor = Color.Teal;
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
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(594, 609);
            Controls.Add(llblRegister);
            Controls.Add(btnLogin);
            Controls.Add(panel2);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtPassword;
        private Label lblPassword;
        private Panel panel2;
        private Button btnLogin;
        private LinkLabel llblRegister;
        private Label lblLogin;
        private PictureBox pictureBox1;
    }
}