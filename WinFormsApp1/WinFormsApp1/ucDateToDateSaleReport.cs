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
    public partial class ucDateToDateSaleReport : UserControl
    {
        public ucDateToDateSaleReport()
        {
            InitializeComponent();
            InitializeCustomUI();
        }

        private void InitializeCustomUI()
        {
            // Label - Starting Date
            Label lblStart = new Label();
            lblStart.Text = "Starting Date:";
            lblStart.Location = new Point(30, 20);
            lblStart.AutoSize = true;
            this.Controls.Add(lblStart);

            // DateTimePicker - Starting Date
            DateTimePicker dtpStart = new DateTimePicker();
            dtpStart.Name = "dtpStart";
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Size = new Size(120, 25);
            dtpStart.Location = new Point(130, 18);
            this.Controls.Add(dtpStart);

            // Label - Ending Date
            Label lblEnd = new Label();
            lblEnd.Text = "Ending Date:";
            lblEnd.Location = new Point(280, 20);
            lblEnd.AutoSize = true;
            this.Controls.Add(lblEnd);

            // DateTimePicker - Ending Date
            DateTimePicker dtpEnd = new DateTimePicker();
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Format = DateTimePickerFormat.Short;
            dtpEnd.Size = new Size(120, 25);
            dtpEnd.Location = new Point(380, 18);
            this.Controls.Add(dtpEnd);

            // Button - Search
            Button btnSearch = new Button();
            btnSearch.Text = "Search";
            btnSearch.Location = new Point(520, 17);
            btnSearch.Size = new Size(80, 28);
            btnSearch.Click += BtnSearch_Click;
            this.Controls.Add(btnSearch);

            // DataGridView
            DataGridView dgv = new DataGridView();
            dgv.Name = "dgvSales";
            dgv.Location = new Point(30, 60);
            dgv.Size = new Size(700, 220);
            dgv.ColumnCount = 5;
            dgv.Columns[0].Name = "SId";
            dgv.Columns[1].Name = "CompanyName";
            dgv.Columns[2].Name = "ModelName";
            dgv.Columns[3].Name = "IMEI No";
            dgv.Columns[4].Name = "Price";
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.Controls.Add(dgv);

            // Label - Total
            Label lblTotal = new Label();
            lblTotal.Name = "lblTotal";
            lblTotal.Text = "Total Sales Amount between [Start] and [End] is = 0";
            lblTotal.Location = new Point(30, 295);
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);
            this.Controls.Add(lblTotal);
        }


        private void BtnSearch_Click(object sender, EventArgs e)
        {
            
        }
    }
}
