using System;
using System.Windows.Forms;

namespace mobileshope
{
    public partial class AdminForm : Form
    {
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
    }
}
