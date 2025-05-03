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
            lblTitle.Location = new Point(537, 91);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(375, 78);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Admin Login";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.Black;
            lblUsername.Location = new Point(83, 293);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(251, 40);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username/Email:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.Black;
            lblPassword.Location = new Point(116, 400);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(155, 40);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // txtAdminUsername
            // 
            txtAdminUsername.BackColor = Color.White;
            txtAdminUsername.Font = new Font("Segoe UI", 10F);
            txtAdminUsername.ForeColor = Color.Black;
            txtAdminUsername.Location = new Point(382, 293);
            txtAdminUsername.Name = "txtAdminUsername";
            txtAdminUsername.Size = new Size(618, 43);
            txtAdminUsername.TabIndex = 3;
            // 
            // txtAdminPassword
            // 
            txtAdminPassword.BackColor = Color.White;
            txtAdminPassword.Font = new Font("Segoe UI", 10F);
            txtAdminPassword.ForeColor = Color.Black;
            txtAdminPassword.Location = new Point(382, 400);
            txtAdminPassword.Name = "txtAdminPassword";
            txtAdminPassword.PasswordChar = '*';
            txtAdminPassword.Size = new Size(618, 43);
            txtAdminPassword.TabIndex = 4;
            // 
            // btnAdminLogin
            // 
            btnAdminLogin.BackColor = Color.FromArgb(64, 64, 64);
            btnAdminLogin.FlatStyle = FlatStyle.Flat;
            btnAdminLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminLogin.ForeColor = Color.White;
            btnAdminLogin.Location = new Point(840, 501);
            btnAdminLogin.Name = "btnAdminLogin";
            btnAdminLogin.Size = new Size(160, 91);
            btnAdminLogin.TabIndex = 5;
            btnAdminLogin.Text = "Login";
            btnAdminLogin.UseVisualStyleBackColor = false;
            btnAdminLogin.Click += btnAdminLogin_Click;
            // 
            // linkBackToLogin
            // 
            linkBackToLogin.AutoSize = true;
            linkBackToLogin.Cursor = Cursors.Hand;
            linkBackToLogin.Font = new Font("Segoe UI", 10F);
            linkBackToLogin.ForeColor = SystemColors.ControlText;
            linkBackToLogin.LinkColor = Color.Black;
            linkBackToLogin.Location = new Point(253, 544);
            linkBackToLogin.Name = "linkBackToLogin";
            linkBackToLogin.Size = new Size(177, 37);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1276, 755);
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
            panel2.Location = new Point(55, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(1157, 662);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            pictureBox1.Image = Image.FromFile("Resources/LogoUTH.png");
            // 
            pictureBox1.Location = new Point(41, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(347, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // AdminLoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1275, 759);
            Controls.Add(panel1);
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
        private PictureBox pictureBox1;
    }
}