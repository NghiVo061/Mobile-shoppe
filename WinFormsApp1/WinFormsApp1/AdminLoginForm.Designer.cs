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
            lblTitle.Location = new Point(308, 31);
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
            lblUsername.Location = new Point(11, 141);
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
            lblPassword.Location = new Point(38, 232);
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
            txtAdminUsername.Location = new Point(225, 141);
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
            txtAdminPassword.Location = new Point(225, 234);
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
            btnAdminLogin.Location = new Point(588, 338);
            btnAdminLogin.Margin = new Padding(2, 2, 2, 2);
            btnAdminLogin.Name = "btnAdminLogin";
            btnAdminLogin.Size = new Size(123, 71);
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
            linkBackToLogin.Location = new Point(64, 373);
            linkBackToLogin.Margin = new Padding(2, 0, 2, 0);
            linkBackToLogin.Name = "linkBackToLogin";
            linkBackToLogin.Size = new Size(130, 28);
            linkBackToLogin.TabIndex = 9;
            linkBackToLogin.TabStop = true;
            linkBackToLogin.Text = "Back to Login";
            linkBackToLogin.LinkClicked += linkBackToLogin_LinkClicked;
            // 
            // AdminLoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(772, 447);
            Controls.Add(linkBackToLogin);
            Controls.Add(btnAdminLogin);
            Controls.Add(txtAdminPassword);
            Controls.Add(txtAdminUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblTitle);
            Margin = new Padding(2, 2, 2, 2);
            Name = "AdminLoginForm";
            Text = "Admin Login";
            Load += AdminLoginForm_Load;
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