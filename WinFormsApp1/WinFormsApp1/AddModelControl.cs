using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AddModelControl : UserControl
    {
        private string connectionString = @"Data Source=DESKTOP-7BK01OJ;Initial Catalog=MobileShopedb;Integrated Security=True;";

        public AddModelControl()
        {
            InitializeComponent();

            LoadCompanies();


            if (cboCompanyName.Items.Count > 0)
                cboCompanyName.SelectedIndex = 0;

            // Vô hiệu hóa txtModelID vì đây là cột Identity, SQL Server sẽ tự tạo
            txtModelID.Enabled = false;
            txtModelID.Text = "Auto-generated";
        }

        private void LoadCompanies()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT CompId, Cname FROM tbl_Company";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cboCompanyName.Items.Add(new { CompanyID = reader.GetInt32(0), CompanyName = reader.GetString(1) });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi nạp danh sách công ty: {ex.Message}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ form
            var selectedCompany = cboCompanyName.SelectedItem;
            string modelNumber = txtModelNumber.Text;

            // Kiểm tra dữ liệu đầu vào
            if (selectedCompany == null || string.IsNullOrWhiteSpace(modelNumber))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin: Tên công ty và Model Name.");
                return;
            }

            // Lấy CompanyID từ selectedCompany
            int companyId = (int)selectedCompany.GetType().GetProperty("CompanyID").GetValue(selectedCompany);
            string companyName = selectedCompany.GetType().GetProperty("CompanyName").GetValue(selectedCompany).ToString();

            // Thêm vào bảng tbl_Model
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO tbl_Model (CompID, ModelNum, AvailableQty) " +
                                 "VALUES (@CompID, @ModelNum, @AvailableQty)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CompID", companyId);
                        command.Parameters.AddWithValue("@ModelNum", modelNumber);
                        command.Parameters.AddWithValue("@AvailableQty", 0); // Giá trị mặc định cho AvailableQty

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Đã thêm Model:\nCông ty: {companyName}\nModel: {modelNumber}");

                // Xóa dữ liệu nhập sau khi thêm thành công
                txtModelNumber.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm model: {ex.Message}");
            }
        }

        private void cboCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Có thể thêm logic nếu cần (ví dụ: lọc dữ liệu khác dựa trên công ty)
        }
    }
}