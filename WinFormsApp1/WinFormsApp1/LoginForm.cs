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
            string password = txtPassword.Text;

            // Kiểm tra đầu vào
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
                        string userName = reader["UserName"] != DBNull.Value ? reader["UserName"].ToString() : string.Empty;
                        if (!string.IsNullOrEmpty(userName) && userName.ToLower() == "admin1")
                        {
                            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    conn.Close();
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
    }
}