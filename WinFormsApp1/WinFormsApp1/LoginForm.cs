using mobileshope;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {

        private string connectionString = @"Server=RANG_DONG\MSSQLSERVER01;Database=MobileShopedb;Integrated Security=True;Encrypt=False;";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string passwordInput = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT UserName, PWD, EmployeeName FROM tbl_User WHERE UserName = @username";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string storedHash = reader["PWD"]?.ToString() ?? "";
                        string userName = reader["UserName"]?.ToString() ?? "";

                        // So sánh mật khẩu người dùng nhập với mật khẩu đã băm
                        if (BCrypt.Net.BCrypt.Verify(passwordInput, storedHash))
                        {
                            if (!string.IsNullOrEmpty(userName) && userName.ToLower() == "admin1")
                            {
                                MessageBox.Show("Tài khoản này không phải nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                EmployeeForm employeeForm = new EmployeeForm();
                                employeeForm.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void linkAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Mở AdminLoginForm và ẩn LoginForm
                AdminLoginForm adminLoginForm = new AdminLoginForm();
                adminLoginForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở AdminLoginForm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkForgetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}