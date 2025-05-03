using System.Data.SqlClient;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class SearchCustomerEmployeeForm : UserControl
    {
        public SearchCustomerEmployeeForm()
        {
            InitializeComponent();
            dataGridViewResults.AutoGenerateColumns = true; // 👈 Quan trọng
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string imei = txtImei.Text.Trim();

            if (string.IsNullOrWhiteSpace(imei))
            {
                MessageBox.Show("IMEI cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (imei.Length != 15 || !imei.All(char.IsDigit))
            {
                MessageBox.Show("IMEI must be 15 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Server=RANG_DONG\MSSQLSERVER01;Database=MobileShopedb;Integrated Security=True;Encrypt=False;"))
                {
                    conn.Open();
                    string query = @"
                        SELECT c.Cust_Name, c.MobileNumber, c.EmailId, c.Address
                        FROM tbl_Sales s
                        JOIN tbl_Customer c ON s.CustId = c.CustId
                        WHERE s.IMEINO = @imei";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@imei", imei);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No customer found with this IMEI.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    dataGridViewResults.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchCustomerEmployeeForm_Load(object sender, EventArgs e)
        {
            dataGridViewResults.AutoGenerateColumns = true; // để an toàn gán thêm lần nữa
        }

        private void txtIMEI_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
