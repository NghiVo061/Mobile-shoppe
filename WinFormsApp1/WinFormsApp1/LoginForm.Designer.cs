namespace WinFormsApp1
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            linkAdmin = new LinkLabel();
            linkForgotPass = new LinkLabel();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 22.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(524, 113);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(182, 78);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Login";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.Black;
            lblUsername.Location = new Point(71, 278);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(164, 40);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.Black;
            lblPassword.Location = new Point(71, 388);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(155, 40);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(326, 275);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(617, 43);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(326, 387);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(617, 43);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(64, 64, 64);
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(783, 521);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(160, 91);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkAdmin
            // 
            linkAdmin.AutoSize = true;
            linkAdmin.Cursor = Cursors.Hand;
            linkAdmin.Font = new Font("Segoe UI", 12F);
            linkAdmin.LinkColor = Color.Black;
            linkAdmin.Location = new Point(870, 113);
            linkAdmin.Name = "linkAdmin";
            linkAdmin.Size = new Size(114, 45);
            linkAdmin.TabIndex = 8;
            linkAdmin.TabStop = true;
            linkAdmin.Text = "Admin";
            linkAdmin.LinkClicked += linkAdmin_LinkClicked;
            // 
            // linkForgotPass
            // 
            linkForgotPass.AutoSize = true;
            linkForgotPass.Cursor = Cursors.Hand;
            linkForgotPass.Font = new Font("Segoe UI", 10F);
            linkForgotPass.ForeColor = SystemColors.ControlText;
            linkForgotPass.LinkColor = Color.Black;
            linkForgotPass.Location = new Point(102, 550);
            linkForgotPass.Name = "linkForgotPass";
            linkForgotPass.Size = new Size(224, 37);
            linkForgotPass.TabIndex = 9;
            linkForgotPass.TabStop = true;
            linkForgotPass.Text = "Forget Password?";
            linkForgotPass.LinkClicked += linkForgetPass_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(6, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1167, 722);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblTitle);
            panel2.Controls.Add(linkForgotPass);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(lblPassword);
            panel2.Controls.Add(linkAdmin);
            panel2.Controls.Add(lblUsername);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(btnLogin);
            panel2.Location = new Point(47, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(1071, 642);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Image.FromFile("Resources/LogoUTH.png");
            pictureBox1.Location = new Point(43, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(346, 178);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1176, 728);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "Login";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private LinkLabel linkAdmin;
        private LinkLabel linkForgotPass;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}

