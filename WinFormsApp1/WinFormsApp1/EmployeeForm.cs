using System;
using System.Drawing; // Thêm để dùng Color
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class EmployeeForm : Form
    {
        // Khai báo các user control
        private SaleEmployeeForm saleEmployeeForm;
        private ViewStockEmployeeForm viewStockEmployeeForm;
        private SearchCustomerEmployeeForm searchCustomerEmployeeForm;

        public EmployeeForm()
        {
            InitializeComponent();

            // Đặt màu nền cho panelContent để dễ kiểm tra
            panelContent.BackColor = Color.LightGray;

            // Khởi tạo các user control
            saleEmployeeForm = new SaleEmployeeForm();
            viewStockEmployeeForm = new ViewStockEmployeeForm();
            searchCustomerEmployeeForm = new SearchCustomerEmployeeForm();

            // Đặt các user control vào panelContent nhưng chưa hiển thị
            saleEmployeeForm.Dock = DockStyle.Fill;
            viewStockEmployeeForm.Dock = DockStyle.Fill;
            searchCustomerEmployeeForm.Dock = DockStyle.Fill;

            panelContent.Controls.Add(saleEmployeeForm);
            panelContent.Controls.Add(viewStockEmployeeForm);
            panelContent.Controls.Add(searchCustomerEmployeeForm);

            // Không hiển thị UserControl nào khi mở form
            saleEmployeeForm.Visible = false;
            viewStockEmployeeForm.Visible = false;
            searchCustomerEmployeeForm.Visible = false;
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            // Ẩn tất cả user control khác và hiển thị SaleEmployeeForm
            saleEmployeeForm.Visible = true;
            viewStockEmployeeForm.Visible = false;
            searchCustomerEmployeeForm.Visible = false;
        }

        private void btnViewStock_Click(object sender, EventArgs e)
        {
            // Ẩn tất cả user control khác và hiển thị ViewStockEmployeeForm
            saleEmployeeForm.Visible = false;
            viewStockEmployeeForm.Visible = true;
            searchCustomerEmployeeForm.Visible = false;
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            // Ẩn tất cả user control khác và hiển thị SearchCustomerEmployeeForm
            saleEmployeeForm.Visible = false;
            viewStockEmployeeForm.Visible = false;
            searchCustomerEmployeeForm.Visible = true;
        }
    }
}