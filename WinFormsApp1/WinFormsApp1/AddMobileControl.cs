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
    public partial class AddMobileControl : UserControl
    {
        public AddMobileControl()
        {
            InitializeComponent();

            // Nạp danh sách công ty
            

            // Nạp danh sách thời hạn bảo hành
            cboWarrantyDate.Items.Add("6 months");
            cboWarrantyDate.Items.Add("1 year");
            cboWarrantyDate.Items.Add("2 years");

            if (cboCompanyName.Items.Count > 0)
                cboCompanyName.SelectedIndex = 0;

            cboWarrantyDate.SelectedIndex = 0;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string companyName = cboCompanyName.SelectedItem?.ToString();
            string modelNumber = cboModelNumber.SelectedItem?.ToString();
            string imeiNumber = txtIMEINumber.Text;
            string price = txtPrice.Text;
            string warrantyDate = cboWarrantyDate.SelectedItem?.ToString();

            // Kiểm tra đơn giản
            if (string.IsNullOrWhiteSpace(modelNumber) || string.IsNullOrWhiteSpace(imeiNumber) || string.IsNullOrWhiteSpace(price))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            MessageBox.Show($"Đã thêm Mobile:\n{companyName} - {modelNumber}\nIMEI: {imeiNumber}, Giá: {price}, Bảo hành: {warrantyDate}");
        }
    }
}
