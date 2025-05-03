using System;
using System.Drawing; 
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class EmployeeForm : Form
    {
        
        private SaleEmployeeForm saleEmployeeForm;
        private ViewStockEmployeeForm viewStockEmployeeForm;
        private SearchCustomerEmployeeForm searchCustomerEmployeeForm;

        public EmployeeForm()
        {
            InitializeComponent();

            
            panelContent.BackColor = Color.LightGray;

            
            saleEmployeeForm = new SaleEmployeeForm();
            viewStockEmployeeForm = new ViewStockEmployeeForm();
            searchCustomerEmployeeForm = new SearchCustomerEmployeeForm();

            
            saleEmployeeForm.Dock = DockStyle.Fill;
            viewStockEmployeeForm.Dock = DockStyle.Fill;
            searchCustomerEmployeeForm.Dock = DockStyle.Fill;

            panelContent.Controls.Add(saleEmployeeForm);
            panelContent.Controls.Add(viewStockEmployeeForm);
            panelContent.Controls.Add(searchCustomerEmployeeForm);

            
            saleEmployeeForm.Visible = false;
            viewStockEmployeeForm.Visible = false;
            searchCustomerEmployeeForm.Visible = false;
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            
            saleEmployeeForm.Visible = true;
            viewStockEmployeeForm.Visible = false;
            searchCustomerEmployeeForm.Visible = false;
        }

        private void btnViewStock_Click(object sender, EventArgs e)
        {
            
            saleEmployeeForm.Visible = false;
            viewStockEmployeeForm.Visible = true;
            searchCustomerEmployeeForm.Visible = false;
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
           
            saleEmployeeForm.Visible = false;
            viewStockEmployeeForm.Visible = false;
            searchCustomerEmployeeForm.Visible = true;
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}