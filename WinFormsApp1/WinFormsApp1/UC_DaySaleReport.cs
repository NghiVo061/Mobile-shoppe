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
    public partial class UC_DaySaleReport : UserControl
    {
        public UC_DaySaleReport()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            // Label "Select Date"
            Label lblDate = new Label();
            lblDate.Text = "Select Date:";
            lblDate.Location = new Point(30, 20);
            lblDate.AutoSize = true;
            this.Controls.Add(lblDate);

            // DateTimePicker
            DateTimePicker dtpDate = new DateTimePicker();
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(120, 15);
            this.Controls.Add(dtpDate);

           

            // DataGridView
            DataGridView dgvSales = new DataGridView();
            dgvSales.Location = new Point(20, 60);
            dgvSales.Size = new Size(500, 200);
            dgvSales.Columns.Add("SId", "SId");
            dgvSales.Columns.Add("CompanyName", "CompanyName");
            dgvSales.Columns.Add("ModelName", "ModelName");
            dgvSales.Columns.Add("IMEI", "IMEI No");
            dgvSales.Columns.Add("Price", "Price");
            this.Controls.Add(dgvSales);

            // Total Sales Label
            Label lblTotal = new Label();
            lblTotal.Text = "Total Sales Amount of [Date] is = 0";
            lblTotal.Location = new Point(20, 270);
            lblTotal.AutoSize = true;
            this.Controls.Add(lblTotal);
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }
        private void lblDate_Click(object sender, EventArgs e)
        {

        }
    }
}
