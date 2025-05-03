namespace WinFormsApp1
{
    partial class AdminLoginForm
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

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtAdminUsername = new TextBox();
            txtAdminPassword = new TextBox();
            btnAdminLogin = new Button();
            linkBackToLogin = new LinkLabel();
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
            lblTitle.Location = new Point(413, 71);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(288, 61);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Admin Login";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.Black;
            lblUsername.Location = new Point(64, 229);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(189, 30);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username/Email:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.Black;
            lblPassword.Location = new Point(89, 312);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(118, 30);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // txtAdminUsername
            // 
            txtAdminUsername.BackColor = Color.White;
            txtAdminUsername.Font = new Font("Segoe UI", 10F);
            txtAdminUsername.ForeColor = Color.Black;
            txtAdminUsername.Location = new Point(294, 229);
            txtAdminUsername.Margin = new Padding(2, 2, 2, 2);
            txtAdminUsername.Name = "txtAdminUsername";
            txtAdminUsername.Size = new Size(476, 34);
            txtAdminUsername.TabIndex = 3;
            // 
            // txtAdminPassword
            // 
            txtAdminPassword.BackColor = Color.White;
            txtAdminPassword.Font = new Font("Segoe UI", 10F);
            txtAdminPassword.ForeColor = Color.Black;
            txtAdminPassword.Location = new Point(294, 312);
            txtAdminPassword.Margin = new Padding(2, 2, 2, 2);
            txtAdminPassword.Name = "txtAdminPassword";
            txtAdminPassword.PasswordChar = '*';
            txtAdminPassword.Size = new Size(476, 34);
            txtAdminPassword.TabIndex = 4;
            // 
            // btnAdminLogin
            // 
            btnAdminLogin.BackColor = Color.FromArgb(64, 64, 64);
            btnAdminLogin.FlatStyle = FlatStyle.Flat;
            btnAdminLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminLogin.ForeColor = Color.White;
            btnAdminLogin.Location = new Point(646, 391);
            btnAdminLogin.Margin = new Padding(2, 2, 2, 2);
            btnAdminLogin.Name = "btnAdminLogin";
            btnAdminLogin.Size = new Size(123, 71);
            btnAdminLogin.TabIndex = 5;
            btnAdminLogin.Text = "Login";
            btnAdminLogin.UseVisualStyleBackColor = false;
            btnAdminLogin.Click += btnAdminLogin_Click;
            // 

            // linkForgotPass
            linkForgotPass = new LinkLabel();
            linkForgotPass.AutoSize = true;
            linkForgotPass.Cursor = Cursors.Hand;
            linkForgotPass.Font = new Font("Segoe UI", 10F);
            linkForgotPass.LinkColor = Color.Black;
            linkForgotPass.Location = new Point(195, 475); // chỉnh sửa vị trí cho phù hợp
            linkForgotPass.Name = "linkForgotPass";
            linkForgotPass.Size = new Size(224, 37);
            linkForgotPass.TabIndex = 10;
            linkForgotPass.TabStop = true;
            linkForgotPass.Text = "Forget Password?";
            linkForgotPass.LinkClicked += linkForgotPass_LinkClicked;

            // linkBackToLogin
            // 
            linkBackToLogin.AutoSize = true;
            linkBackToLogin.Cursor = Cursors.Hand;
            linkBackToLogin.Font = new Font("Segoe UI", 10F);
            linkBackToLogin.ForeColor = SystemColors.ControlText;
            linkBackToLogin.LinkColor = Color.Black;
            linkBackToLogin.Location = new Point(195, 425);
            linkBackToLogin.Margin = new Padding(2, 0, 2, 0);
            linkBackToLogin.Name = "linkBackToLogin";
            linkBackToLogin.Size = new Size(130, 28);
            linkBackToLogin.TabIndex = 9;
            linkBackToLogin.TabStop = true;
            linkBackToLogin.Text = "Back to Login";
            linkBackToLogin.LinkClicked += linkBackToLogin_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 590);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblTitle);
            panel2.Controls.Add(linkBackToLogin);
            panel2.Controls.Add(txtAdminUsername);
            panel2.Controls.Add(lblPassword);
            panel2.Controls.Add(btnAdminLogin);
            panel2.Controls.Add(lblUsername);
            panel2.Controls.Add(txtAdminPassword);
            panel2.Controls.Add(linkForgotPass);

            panel2.Location = new Point(42, 30);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(890, 517);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(32, 34);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(267, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // AdminLoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(981, 593);
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "AdminLoginForm";
            Text = "Admin Login";
            Load += AdminLoginForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private Label lblTitle;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtAdminUsername;
        private TextBox txtAdminPassword;
        private Button btnAdminLogin;
        private LinkLabel linkBackToLogin;
        private Panel panel1;
        private Panel panel2;
        private LinkLabel linkForgotPass;
        private PictureBox pictureBox1;
    }
}