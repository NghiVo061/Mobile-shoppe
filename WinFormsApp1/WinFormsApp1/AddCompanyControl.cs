using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AddCompanyControl : UserControl
    {
        public AddCompanyControl()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string companyId = textBox1.Text.Trim();
            string companyName = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(companyId) || string.IsNullOrEmpty(companyName))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin công ty.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = @"Data Source=DESKTOP-7BK01OJ;Initial Catalog=MobileShopedb;Integrated Security=True;";

            string query = "INSERT INTO tbl_Company (CompId, Cname) VALUES (@CompanyId, @CompanyName)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@CompanyId", companyId);
                    cmd.Parameters.AddWithValue("@CompanyName", companyName);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm công ty thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox1.Clear();
                            textBox2.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm công ty.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi thêm công ty: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}