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
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 22.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(400, 40);
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
            lblUsername.Location = new Point(14, 181);
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
            lblPassword.Location = new Point(50, 297);
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
            txtAdminUsername.Location = new Point(293, 180);
            txtAdminUsername.Name = "txtAdminUsername";
            txtAdminUsername.Size = new Size(617, 43);
            txtAdminUsername.TabIndex = 3;
            // 
            // txtAdminPassword
            // 
            txtAdminPassword.BackColor = Color.White;
            txtAdminPassword.Font = new Font("Segoe UI", 10F);
            txtAdminPassword.ForeColor = Color.Black;
            txtAdminPassword.Location = new Point(293, 300);
            txtAdminPassword.Name = "txtAdminPassword";
            txtAdminPassword.PasswordChar = '*';
            txtAdminPassword.Size = new Size(617, 43);
            txtAdminPassword.TabIndex = 4;
            // 
            // btnAdminLogin
            // 
            btnAdminLogin.BackColor = Color.FromArgb(64, 64, 64);
            btnAdminLogin.FlatStyle = FlatStyle.Flat;
            btnAdminLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminLogin.ForeColor = Color.White;
            btnAdminLogin.Location = new Point(765, 433);
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
            linkBackToLogin.Location = new Point(83, 477);
            linkBackToLogin.Name = "linkBackToLogin";
            linkBackToLogin.Size = new Size(177, 37);
            linkBackToLogin.TabIndex = 9;
            linkBackToLogin.TabStop = true;
            linkBackToLogin.Text = "Back to Login";
            linkBackToLogin.LinkClicked += linkBackToLogin_LinkClicked;
            // 
            // AdminLoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1003, 572);
            Controls.Add(linkBackToLogin);
            Controls.Add(btnAdminLogin);
            Controls.Add(txtAdminPassword);
            Controls.Add(txtAdminUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblTitle);
            Name = "AdminLoginForm";
            Text = "Admin Login";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtAdminUsername;
        private TextBox txtAdminPassword;
        private Button btnAdminLogin;
        private LinkLabel linkBackToLogin;
    }
}