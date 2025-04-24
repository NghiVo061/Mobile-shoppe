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
    public partial class UpdateStockControl : UserControl
    {
        public UpdateStockControl()
        {
            InitializeComponent();

            // Load danh sách Company Name
            

            
        }

        private void LoadModelsByCompany(string companyName)
        {
            cboModelNumber.Items.Clear();

            if (companyName == "Nokia")
            {
                cboModelNumber.Items.AddRange(new string[] { "n7", "lumia" });
            }
            else if (companyName == "Samsung")
            {
                cboModelNumber.Items.AddRange(new string[] { "s21", "note10" });
            }

            if (cboModelNumber.Items.Count > 0)
                cboModelNumber.SelectedIndex = 0;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string transId = txtTransID.Text;
            string companyName = cboCompanyName.SelectedItem?.ToString();
            string modelNumber = cboModelNumber.SelectedItem?.ToString();
            string quantity = txtQuantity.Text;
            string amount = txtAmount.Text;

           
        }
    }
}
