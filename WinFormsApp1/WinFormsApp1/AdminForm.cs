using System;
using System.Windows.Forms;
using WinFormsApp1;

namespace mobileshope
{
    public partial class AdminForm : Form
    {
        private bool isAddExpanded = false;
        private bool isSaleReportExpanded = false;

        public AdminForm()
        {
            InitializeComponent();

            // Gán sự kiện cho các nút 
           
            btnLogout.Click += (s, e) => this.Close(); // Hoặc quay lại form đăng nhập


        }

        /// <summary>
        /// Hàm tải UserControl vào panelContent
        /// </summary>
        /// <param name="control">UserControl cần hiển thị</param>
        private void LoadUserControl(UserControl control)
        {
            panelContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContent.Controls.Add(control);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            isAddExpanded = !isAddExpanded;

            btnAddCompany.Visible = isAddExpanded;
            btnAddModel.Visible = isAddExpanded;
            btnAddProductType.Visible = isAddExpanded;

            // Adjust position of other buttons
            btnUpdateStock.Top = isAddExpanded ? 220 : 110;
            btnViewSales.Top = isAddExpanded ? 270 : 160;
            btnManageEmployees.Top = isAddExpanded ? 320 : 210;
            btnLogout.Top = isAddExpanded ? 370 : 260;

            // Change icon to indicate expanded/collapsed state
            btnAddProduct.Text = isAddExpanded ? "➖ Add" : "➕ Add";
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            LoadUserControl(new AddCompanyControl());
        }

        private void btnAddModel_Click(object sender, EventArgs e)
        {
            LoadUserControl(new AddModelControl());
        }

        private void btnAddProductType_Click(object sender, EventArgs e)
        {
            LoadUserControl(new AddMobileControl());
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UpdateStockControl());
        }

        private void btnViewSales_Click(object sender, EventArgs e)
        {
            isSaleReportExpanded = !isSaleReportExpanded;

            btnDaySaleReport.Visible = isSaleReportExpanded;
            btnDateToDateSaleReport.Visible = isSaleReportExpanded;

            // Điều chỉnh lại vị trí các nút bên dưới
            btnManageEmployees.Top = isSaleReportExpanded ? 300 : 210;
            btnLogout.Top = isSaleReportExpanded ? 350 : 260;

            // (Tuỳ chọn) đổi lại text của nút ViewSales
            btnViewSales.Text = isSaleReportExpanded ? "📊 Sale Report" : "📊 Sale Report";
        }

        private void btnManageEmployees_Click(object sender, EventArgs e)
        {
            LoadUserControl(new AddEmployeeControl());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Xử lý đăng xuất
            this.Close();
        }

        private void btnDaySaleReport_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_DaySaleReport());
        }

        private void btnDateToDateSaleReport_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucDateToDateSaleReport());
        }

    }
}
