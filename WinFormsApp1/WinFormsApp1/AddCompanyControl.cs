using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AddCompanyControl : UserControl
    {
        public AddCompanyControl()
        {
            InitializeComponent();
        }

        private readonly string connectionString = @"Server=RANG_DONG\MSSQLSERVER01;Database=MobileShopedb;Integrated Security=True;Encrypt=False;";

        private void AddCompanyControl_Load(object sender, EventArgs e)
        {
            GenerateNextCompanyId();
            textBox1.ReadOnly = true; // Không cho sửa ID
        }

        private void GenerateNextCompanyId()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT MAX(CompId) FROM tbl_Company", conn);
                    var result = cmd.ExecuteScalar()?.ToString();

                    if (!string.IsNullOrEmpty(result) && result.StartsWith("C"))
                    {
                        int number = int.Parse(result.Substring(1));
                        textBox1.Text = "C" + (number + 1).ToString("D3");
                    }
                    else
                    {
                        textBox1.Text = "C001";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo mã công ty: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "C001"; // fallback
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string companyId = textBox1.Text;
            string companyName = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(companyName))
            {
                MessageBox.Show("Vui lòng nhập tên công ty.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO tbl_Company (CompId, Cname) VALUES (@CompanyId, @CompanyName)";

            using (SqlConnection conn = new SqlConnection(connectionString))
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
                        textBox2.Clear();
                        GenerateNextCompanyId(); // tạo ID mới tiếp theo
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

        private void label1_Click(object sender, EventArgs e)
        {
            // Optional: sự kiện click label nếu cần
        }
    }
}
