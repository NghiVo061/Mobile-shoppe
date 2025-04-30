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
    public partial class AddMobileControl : UserControl
    {
        private string connectionString = @"Data Source=DESKTOP-7BK01OJ;Initial Catalog=MobileShopedb;Integrated Security=True;";

        public AddMobileControl()
        {
            InitializeComponent();

           
            LoadCompanies();

     
            cboWarrantyDate.Items.Add("6 months");
            cboWarrantyDate.Items.Add("1 year");
            cboWarrantyDate.Items.Add("2 years");

            if (cboCompanyName.Items.Count > 0)
                cboCompanyName.SelectedIndex = 0;

            cboWarrantyDate.SelectedIndex = 0;

       
            cboCompanyName.SelectedIndexChanged += (s, e) => LoadModels();
        }

        private void LoadCompanies()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT CompId, CName FROM tbl_Company";
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

        private void LoadModels()
        {
            cboModelNumber.Items.Clear(); 

            var selectedCompany = cboCompanyName.SelectedItem;
            if (selectedCompany == null) return;

            int companyId = (int)selectedCompany.GetType().GetProperty("CompanyID").GetValue(selectedCompany);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT ModelID, ModelNum FROM tbl_Model WHERE CompID = @CompID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CompID", companyId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cboModelNumber.Items.Add(new { ModelID = reader.GetInt32(0), ModelNum = reader.GetString(1) });
                            }
                        }
                    }
                }

                if (cboModelNumber.Items.Count > 0)
                    cboModelNumber.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi nạp danh sách model: {ex.Message}");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
         
            var selectedCompany = cboCompanyName.SelectedItem;
            var selectedModel = cboModelNumber.SelectedItem;
            string imeiNumber = txtIMEINumber.Text;
            string priceText = txtPrice.Text;
            string warrantyPeriod = cboWarrantyDate.SelectedItem?.ToString();

          
            if (selectedCompany == null || selectedModel == null ||
                string.IsNullOrWhiteSpace(imeiNumber) || string.IsNullOrWhiteSpace(priceText) ||
                string.IsNullOrWhiteSpace(warrantyPeriod))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (!decimal.TryParse(priceText, out decimal price))
            {
                MessageBox.Show("Giá phải là một số hợp lệ.");
                return;
            }

            int companyId = (int)selectedCompany.GetType().GetProperty("CompanyID").GetValue(selectedCompany);
            string companyName = selectedCompany.GetType().GetProperty("CompanyName").GetValue(selectedCompany).ToString();
            int modelId = (int)selectedModel.GetType().GetProperty("ModelID").GetValue(selectedModel);
            string modelNum = selectedModel.GetType().GetProperty("ModelNum").GetValue(selectedModel).ToString();

      
            DateTime warrantyDate;
            DateTime currentDate = DateTime.Now;
            if (warrantyPeriod == "6 months")
                warrantyDate = currentDate.AddMonths(6);
            else if (warrantyPeriod == "1 year")
                warrantyDate = currentDate.AddYears(1);
            else 
                warrantyDate = currentDate.AddYears(2);

          
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO tbl_Mobile (ModelID, IMEINO, Status, Warranty, Price) " +
                                 "VALUES (@ModelID, @IMEINO, @Status, @Warranty, @Price)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ModelID", modelId);
                        command.Parameters.AddWithValue("@IMEINO", imeiNumber);
                        command.Parameters.AddWithValue("@Status", "Active"); 
                        command.Parameters.AddWithValue("@Warranty", warrantyDate);
                        command.Parameters.AddWithValue("@Price", price);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Đã thêm Mobile:\n{companyName} - {modelNum}\nIMEI: {imeiNumber}, Giá: {price}, Bảo hành: {warrantyPeriod}");

             
                txtIMEINumber.Text = "";
                txtPrice.Text = "";
                if (cboModelNumber.Items.Count > 0)
                    cboModelNumber.SelectedIndex = 0;
                cboWarrantyDate.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm mobile: {ex.Message}");
            }
        }
    }
}