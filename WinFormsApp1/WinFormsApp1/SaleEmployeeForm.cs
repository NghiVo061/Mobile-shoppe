using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class SaleEmployeeForm : UserControl
    {
        public SaleEmployeeForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem tất cả các trường có được nhập không
            if (string.IsNullOrEmpty(txtCustomerName.Text) ||
                string.IsNullOrEmpty(txtMobileNumber.Text) ||
                string.IsNullOrEmpty(txtAddress.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtCompanyName.Text) ||
                string.IsNullOrEmpty(txtModelNumber.Text) ||
                string.IsNullOrEmpty(txtIMEI.Text) ||
                string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo form xác nhận và truyền thông tin
            ConfirmForm confirmForm = new ConfirmForm(
                txtCustomerName.Text,
                txtMobileNumber.Text,
                txtAddress.Text,
                txtEmail.Text,
                txtCompanyName.Text,
                txtModelNumber.Text,
                txtIMEI.Text,
                txtPrice.Text
            );
            confirmForm.ShowDialog();
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}