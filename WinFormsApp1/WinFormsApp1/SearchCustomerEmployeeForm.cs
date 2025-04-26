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
    public partial class SearchCustomerEmployeeForm : UserControl
    {
        public SearchCustomerEmployeeForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Lấy số IMEI từ TextBox
            string imei = txtIMEI.Text;

            // Kiểm tra nếu IMEI không rỗng
            if (!string.IsNullOrEmpty(imei))
            {
                // Giả lập dữ liệu (thay thế bằng logic truy vấn cơ sở dữ liệu nếu có)
                dataGridViewResults.Rows.Clear();
                dataGridViewResults.Rows.Add("Raju", "9899756142", "raju@gmail.com", "Hyderabad");
            }
            else
            {
                MessageBox.Show("Please enter an IMEI number.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}