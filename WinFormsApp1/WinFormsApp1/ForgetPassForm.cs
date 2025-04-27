using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ForgetPassForm : Form
    {
        private string connectionString = "Data Source=DESKTOP-TU6VN7B;Initial Catalog=MobileShopedb;Integrated Security=True;Trust Server Certificate=True";
        public ForgetPassForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Khi nhấn vào "Login", mở LoginForm và đóng ForgetPassForm
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Logic xử lý khi nhấn nút Send (có thể để trống hoặc thêm logic lấy mật khẩu)
            MessageBox.Show("Password recovery email sent! (This is a placeholder message)");
        }
    }
}