<<<<<<< HEAD
﻿using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            string username = txtAdminUsername.Text;
            string password = txtAdminPassword.Text;

            // Kiểm tra đăng nhập admin (có thể thay đổi logic kiểm tra)
            if (username == "admin" && password == "admin123")
            {
                MessageBox.Show("Đăng nhập admin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Có thể mở form quản lý admin ở đây
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu admin không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Quay lại LoginForm và ẩn AdminLoginForm
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
=======
﻿using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AdminLoginForm : Form
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            string username = txtAdminUsername.Text;
            string password = txtAdminPassword.Text;

            // Kiểm tra đăng nhập admin (có thể thay đổi logic kiểm tra)
            if (username == "admin" && password == "admin123")
            {
                MessageBox.Show("Đăng nhập admin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Có thể mở form quản lý admin ở đây
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu admin không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Quay lại LoginForm và ẩn AdminLoginForm
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
>>>>>>> b15efc742110c9ed2387cef864d220433f5d5e02
}