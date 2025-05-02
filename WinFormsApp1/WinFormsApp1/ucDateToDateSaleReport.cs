using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ucDateToDateSaleReport : UserControl
    {
        private string connectionString = @"Server=RANG_DONG\MSSQLSERVER01;Database=MobileShopedb;Integrated Security=True;Encrypt=False;";

        public ucDateToDateSaleReport()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStart.Value.Date;
            DateTime endDate = dtpEnd.Value.Date;

            if (startDate > endDate)
            {
                MessageBox.Show("Start Date cannot be after End Date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvSales.Rows.Clear();

            // Initialize total price
            decimal totalPrice = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT s.SlsId, c.CName, model.ModelNum, mob.IMEINO, s.Price
                        FROM [dbo].[tbl_Sales] s
                        INNER JOIN [dbo].[tbl_Mobile] mob ON s.IMEINO = mob.IMEINO
                        INNER JOIN [dbo].[tbl_Model] model ON mob.ModelId = model.ModelId
                        INNER JOIN [dbo].[tbl_Company] c ON model.CompId = c.CompId
                        WHERE s.PurchaseDate BETWEEN @StartDate AND @EndDate";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StartDate", startDate);
                        cmd.Parameters.AddWithValue("@EndDate", endDate);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dgvSales.Rows.Add(
                                    reader["SlsId"].ToString(),
                                    reader["CName"].ToString(),
                                    reader["ModelNum"].ToString(),
                                    reader["IMEINO"].ToString(),
                                    reader["Price"].ToString()
                                );
                                if (decimal.TryParse(reader["Price"].ToString(), out decimal price))
                                {
                                    totalPrice += price;
                                }
                            }
                        }
                    }

                    conn.Close();
                }
                lblTotal.Text = $"Total Sales Amount between {startDate.ToString("d")} and {endDate.ToString("d")} is = {totalPrice:C}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching sales data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ucDateToDateSaleReport_Load(object sender, EventArgs e)
        {

        }
    }
}