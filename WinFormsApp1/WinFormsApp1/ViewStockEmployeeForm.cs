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
    public partial class ViewStockEmployeeForm : UserControl
    {
        public ViewStockEmployeeForm()
        {
            InitializeComponent();
        }

        // Xử lý sự kiện khi nhấp vào label "Select Available"
        private void label3_Click(object sender, EventArgs e)
        {
            // Hiện tại để trống, bạn có thể thêm logic nếu cần
        }

        // Xử lý sự kiện khi form được tải
        private void ViewStockEmployeeForm_Load(object sender, EventArgs e)
        {
            // Hiện tại để trống, bạn có thể thêm logic nếu cần
            // Ví dụ: tải danh sách công ty và model vào comboBoxCompanyName và comboBoxModelNumber
        }
    }
}