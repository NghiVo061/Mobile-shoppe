using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ConfirmForm : Form
    {
        public ConfirmForm(string customerName, string mobileNumber, string address, string email, string companyName, string modelNumber, string imei, string price)
        {
            InitializeComponent();

            // Hiển thị thông tin trên form
            lblCustomerName.Text = $"Customer Name: {customerName}";
            lblMobileNumber.Text = $"Mobile Number: {mobileNumber}";
            lblAddress.Text = $"Address: {address}";
            lblEmail.Text = $"Email ID: {email}";
            lblCompanyName.Text = $"Company Name: {companyName}";
            lblModelNumber.Text = $"Model Number: {modelNumber}";
            lblIMEI.Text = $"IMEI Number: {imei}";
            lblPrice.Text = $"Price: {price}";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sale confirmed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}