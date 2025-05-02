using System;
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
        private string connectionString = @"Server=RANG_DONG\MSSQLSERVER01;Database=MobileShopedb;Integrated Security=True;Encrypt=False;";


        public AddModelControl()
        {
            InitializeComponent();

            LoadCompanies();

            if (cboCompanyName.Items.Count > 0)
                cboCompanyName.SelectedIndex = 0;

            // Cho phép nhập ModelID thay vì vô hiệu hóa
            // txtModelID.Enabled = false; // Xóa dòng này
            // txtModelID.Text = "Auto-generated"; // Xóa dòng này
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
                            List<object> companies = new List<object>();
                            while (reader.Read())
                            {
                                companies.Add(new { CompanyID = reader.GetString(0), CompanyName = reader.GetString(1) });

                            }
                            cboCompanyName.DataSource = companies;
                            cboCompanyName.DisplayMember = "CompanyName"; // Hiển thị CompanyName
                            cboCompanyName.ValueMember = "CompanyID";     // Giá trị là CompanyID
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
            var selectedCompany = cboCompanyName.SelectedItem;
            string modelNumber = txtModelNumber.Text;
            string modelIdText = txtModelID.Text; // Lấy ModelID từ trường nhập liệu

            // Kiểm tra dữ liệu đầu vào
            if (selectedCompany == null || string.IsNullOrWhiteSpace(modelNumber) || string.IsNullOrWhiteSpace(modelIdText))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin: Tên công ty, Model ID và Model Name.");
                return;
            }

            // Chuyển đổi ModelID thành số nguyên
            if (!int.TryParse(modelIdText, out int modelId))
            {
                MessageBox.Show("Model ID phải là một số hợp lệ.");
                return;
            }

            string companyId = (string)cboCompanyName.SelectedValue; // Lấy CompanyID từ ValueMember
            string companyName = cboCompanyName.Text;         // Lấy CompanyName từ DisplayMember

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO tbl_Model (ModelID, CompID, ModelNum, AvailableQty) " +
                                 "VALUES (@ModelID, @CompID, @ModelNum, @AvailableQty)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ModelID", modelId);      // Sử dụng ModelID do người dùng nhập
                        command.Parameters.AddWithValue("@CompID", companyId);
                        command.Parameters.AddWithValue("@ModelNum", modelNumber);
                        command.Parameters.AddWithValue("@AvailableQty", 0);       // Mặc định là 0

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Đã thêm Model:\nCông ty: {companyName}\nModel ID: {modelId}, Model: {modelNumber}");

                // Xóa nội dung sau khi thêm thành công
                txtModelID.Text = "";
                txtModelNumber.Text = "";
            }
            catch (Exception ex)
            {
                // Kiểm tra lỗi trùng lặp ModelID (nếu có khóa chính)
                if (ex.Message.Contains("duplicate"))
                    MessageBox.Show("Model ID đã tồn tại. Vui lòng chọn ID khác.");
                else
                    MessageBox.Show($"Lỗi khi thêm model: {ex.Message}");
            }
        }

        private void cboCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Để trống hoặc thêm logic khác nếu cần
        }

        private void AddModelControl_Load(object sender, EventArgs e)
        {

        }
    }
}