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
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 22.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(400, 40);
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
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(293, 180);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(617, 43);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(293, 300);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(617, 43);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(64, 64, 64);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(765, 433);
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
            linkAdmin.Location = new Point(821, 35);
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
            linkForgotPass.Location = new Point(83, 477);
            linkForgotPass.Name = "linkForgotPass";
            linkForgotPass.Size = new Size(224, 37);
            linkForgotPass.TabIndex = 9;
            linkForgotPass.TabStop = true;
            linkForgotPass.Text = "Forget Password?";
            linkForgotPass.LinkClicked += linkForgetPass_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(976, 563);
            Controls.Add(linkForgotPass);
            Controls.Add(linkAdmin);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblTitle);
            Name = "LoginForm";
            Text = "Login";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
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
    }
}
