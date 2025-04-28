using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using BCrypt.Net;

namespace WinFormsApp1
{
    public partial class AddEmployeeControl : UserControl
    {
        private string connectionString = @"Server=DESKTOP-7RHBQE4\SQLEXPRESS;Database=MobileShopedb;Integrated Security=True;Encrypt=False";
        public AddEmployeeControl()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click_1(object sender, EventArgs e)
        {
            string name = txtEmpName.Text.Trim();
            string address = txtAddress.Text.Trim();
            string mobile = txtMobile.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string retypePassword = txtRetypePassword.Text.Trim();
            string hint = txtHint.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(mobile) || string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(hint))
            {
                MessageBox.Show("Vui lòng điền đầy đủ tất cả các trường!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (address.Length < 15)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ số nhà, tên đường, phường/xã, quận/huyện, tỉnh/thành phố.",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != retypePassword)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (mobile.Length < 10 || !mobile.All(char.IsDigit))
            {
                MessageBox.Show("Vui lòng nhập đúng số điện thoại 10 số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO tbl_User (Username, PWD, EmployeeName, Address, MobileNumber, Hint) " +
                                   "VALUES (@Username, @PWD, @EmployeeName, @Address, @MobileNumber, @Hint)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@PWD", hashedPassword);
                        command.Parameters.AddWithValue("@EmployeeName", name);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@MobileNumber", mobile);
                        command.Parameters.AddWithValue("@Hint", hint);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Thêm nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtEmpName.Clear();
                    txtAddress.Clear();
                    txtMobile.Clear();
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtRetypePassword.Clear();
                    txtHint.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}