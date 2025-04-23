using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mobileshope
{
    public partial class MainLoginForm : Form
    {
        public MainLoginForm()
        {
            InitializeComponent();
            SetupUserLoginUI();
        }

        private void SetupUserLoginUI()
        {
           

            // Cấu hình chung cho form
            this.Text = "User Login";
            this.Size = new Size(400, 350);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // Label "Admin" (ở góc trên bên phải) (name admin=lnkAdmin)
            LinkLabel lnkAdmin = new LinkLabel();
            lnkAdmin.Text = "Admin";
            lnkAdmin.Location = new Point(320, 15);
            lnkAdmin.AutoSize = true;
            lnkAdmin.LinkColor = Color.Blue;

            lnkAdmin.Click += (sender, e) => {
                this.Hide(); // Ẩn form user đi
                AdminLoginForm adminForm = new AdminLoginForm();
                adminForm.FormClosed += (s, args) => this.Show(); // Khi đóng form admin thì hiện lại form user
                adminForm.Show();
            };

            this.Controls.Add(lnkAdmin);



            // Label tiêu đề (name =lblTitle)
            Label lblTitle = new Label();
            lblTitle.Text = "USER LOGIN";
            lblTitle.Font = new Font("Arial", 18, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(140, 40);
            this.Controls.Add(lblTitle);

            // Label và TextBox cho Username (name =lblUsername) (textbox name = txtUsername)
            Label lblUsername = new Label();
            lblUsername.Text = "Username:";
            lblUsername.Font = new Font("Arial", 10);
            lblUsername.Location = new Point(80, 100);
            this.Controls.Add(lblUsername);

            TextBox txtUsername = new TextBox();
            txtUsername.Name = "txtUsername";
            txtUsername.Location = new Point(80, 125);
            txtUsername.Size = new Size(240, 25);
            txtUsername.Font = new Font("Arial", 10);
            this.Controls.Add(txtUsername);

            // Label và TextBox cho Password (name = lblPassword) (textbox name = txtPassword)
            Label lblPassword = new Label();
            lblPassword.Text = "Password:";
            lblPassword.Font = new Font("Arial", 10);
            lblPassword.Location = new Point(80, 170);
            this.Controls.Add(lblPassword);

            TextBox txtPassword = new TextBox();
            txtPassword.Name = "txtPassword";
            txtPassword.Location = new Point(80, 195);
            txtPassword.Size = new Size(240, 25);
            txtPassword.Font = new Font("Arial", 10);
            txtPassword.PasswordChar = '*';
            this.Controls.Add(txtPassword);

            // LinkLabel "Forgot Password?" (link label name =lnkForgotPassword)
            LinkLabel lnkForgotPassword = new LinkLabel();
            lnkForgotPassword.Text = "Forgot Password?";
            lnkForgotPassword.Font = new Font("Arial", 9);
            lnkForgotPassword.Location = new Point(220, 230);
            lnkForgotPassword.AutoSize = true;
            lnkForgotPassword.LinkColor = Color.Blue;
            this.Controls.Add(lnkForgotPassword);

            // Nút Login (button name = btnLogin)
            Button btnLogin = new Button();
            btnLogin.Text = "LOGIN";
            btnLogin.Font = new Font("Arial", 10, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.BackColor = Color.DodgerBlue;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Size = new Size(240, 35);
            btnLogin.Location = new Point(80, 260);
            this.Controls.Add(btnLogin);
        }

        private void lnkAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
