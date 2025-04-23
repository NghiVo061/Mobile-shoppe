using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mobileshope
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
            SetupAdminLoginUI();
        }

        private void SetupAdminLoginUI()
        {
            // Cấu hình chung cho form
            this.Text = "Admin Login";
            this.Size = new Size(400, 300);
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // Label tiêu đề
            Label lblTitle = new Label();
            lblTitle.Text = "ADMIN LOGIN";
            lblTitle.Font = new Font("Arial", 18, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkRed;
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(130, 40);
            this.Controls.Add(lblTitle);

            // Label và TextBox cho Username
            Label lblUsername = new Label();
            lblUsername.Text = "Username:";
            lblUsername.Font = new Font("Arial", 10);
            lblUsername.Location = new Point(80, 90);
            this.Controls.Add(lblUsername);

            TextBox txtUsername = new TextBox();
            txtUsername.Name = "txtAdminUsername";
            txtUsername.Location = new Point(80, 115);
            txtUsername.Size = new Size(240, 25);
            txtUsername.Font = new Font("Arial", 10);
            this.Controls.Add(txtUsername);

            // Label và TextBox cho Password
            Label lblPassword = new Label();
            lblPassword.Text = "Password:";
            lblPassword.Font = new Font("Arial", 10);
            lblPassword.Location = new Point(80, 150);
            this.Controls.Add(lblPassword);

            TextBox txtPassword = new TextBox();
            txtPassword.Name = "txtAdminPassword";
            txtPassword.Location = new Point(80, 175);
            txtPassword.Size = new Size(240, 25);
            txtPassword.Font = new Font("Arial", 10);
            txtPassword.PasswordChar = '*';
            this.Controls.Add(txtPassword);

            LinkLabel lnkBack = new LinkLabel();
            lnkBack.Text = "Back";
            lnkBack.Location = new Point(20, 15); // Góc trên bên trái
            lnkBack.AutoSize = true;
            lnkBack.LinkColor = Color.Blue;

            // Gán sự kiện Click
            lnkBack.Click += (sender, e) => {
                this.Close(); // Đóng form admin
            };

            this.Controls.Add(lnkBack);

            LinkLabel lnkForgotPassword = new LinkLabel();
            lnkForgotPassword.Text = "Forgot Password?";
            lnkForgotPassword.Font = new Font("Arial", 9);
            lnkForgotPassword.Location = new Point(200, 200);
            lnkForgotPassword.AutoSize = true;
            lnkForgotPassword.LinkColor = Color.Blue;
            this.Controls.Add(lnkForgotPassword);

            // Nút Login
            Button btnLogin = new Button();
            btnLogin.Text = "LOGIN";
            btnLogin.Font = new Font("Arial", 10, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.BackColor = Color.OrangeRed;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Size = new Size(240, 35);
            btnLogin.Location = new Point(80, 220);
            this.Controls.Add(btnLogin);
        }
    }
}
