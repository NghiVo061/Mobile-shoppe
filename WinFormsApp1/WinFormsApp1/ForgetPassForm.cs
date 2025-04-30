using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ForgetPassForm : Form
    {
        private string connectionString = "Data Source=DESKTOP-TU6VN7B;Initial Catalog=MobileShopedb;Integrated Security=True";
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
            //MessageBox.Show("Password recovery email sent! (This is a placeholder message)");
            string username = textBox1.Text;
            string hint = textBox2.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(hint))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và gợi ý!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT PWD FROM tbl_User WHERE UserName = @username AND Hint = @hint";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@hint", hint);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string password = reader["PWD"].ToString();
                        MessageBox.Show("Mật khẩu của ban là: " + password, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc gợi ý không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}