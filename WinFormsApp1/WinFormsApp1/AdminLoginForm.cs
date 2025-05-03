using mobileshope;
using System;

//cáu này system
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class AdminLoginForm : Form
    {
        private string connectionString = @"Server=RANG_DONG\MSSQLSERVER01;Database=MobileShopedb;Integrated Security=True;Encrypt=False;";
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            string username = txtAdminUsername.Text;
            string password = txtAdminPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT UserName, EmployeeName FROM tbl_User WHERE UserName = @username AND PWD = @password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Kiểm tra null cho cột UserName
                        string userName = reader["UserName"] != DBNull.Value ? reader["UserName"].ToString() : string.Empty;
                        if (!string.IsNullOrEmpty(userName) && userName.ToLower() == "admin1") // Chỉ cho phép tài khoản admin
                        {
                            //MessageBox.Show("Đăng nhập admin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AdminForm adminForm = new AdminForm();
                            adminForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản này không phải Admin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Quay lại LoginForm và ẩn AdminLoginForm
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void AdminLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.Controls.Add(linkForgotPass);

        }
        private void linkForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Mở ForgetPassForm và ẩn LoginForm
                ForgetPassForm forgetPassForm = new ForgetPassForm();
                forgetPassForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở ForgetPassForm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}