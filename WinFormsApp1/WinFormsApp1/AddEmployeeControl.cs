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
    public partial class AddEmployeeControl : UserControl
    {
        public AddEmployeeControl()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            string name = txtEmpName.Text;
            string address = txtAddress.Text;
            string mobile = txtMobile.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string retypePassword = txtRetypePassword.Text;
            string hint = txtHint.Text;

            

            
        }
    }
}
