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
    public partial class UC_DaySaleReport : UserControl
    {
        private string connectionString = @"Server=DESKTOP-7RHBQE4\SQLEXPRESS;Database=MobileShopedb;Integrated Security=True;Encrypt=False;";

        public UC_DaySaleReport()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpDate.Value.Date;

            dgvSales.Rows.Clear();

            decimal totalPrice = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // SQL query with parameter for a single PurchaseDate
                    string query = @"
                        SELECT s.SlsId, c.CName, model.ModelNum, mob.IMEINO, s.Price
                        FROM [dbo].[tbl_Sales] s
                        INNER JOIN [dbo].[tbl_Mobile] mob ON s.IMEINO = mob.IMEINO
                        INNER JOIN [dbo].[tbl_Model] model ON mob.ModelId = model.ModelId
                        INNER JOIN [dbo].[tbl_Company] c ON model.CompId = c.CompId
                        WHERE CAST(s.PurchaseDate AS DATE) = @SelectedDate";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Add parameter to avoid SQL injection
                        cmd.Parameters.AddWithValue("@SelectedDate", selectedDate);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Add row to DataGridView
                                dgvSales.Rows.Add(
                                    reader["SlsId"].ToString(),
                                    reader["CName"].ToString(),
                                    reader["ModelNum"].ToString(),
                                    reader["IMEINO"].ToString(),
                                    reader["Price"].ToString()
                                );

                                // Accumulate price (convert to decimal)
                                if (decimal.TryParse(reader["Price"].ToString(), out decimal price))
                                {
                                    totalPrice += price;
                                }
                            }
                        }
                    }

                    conn.Close();
                }

                // Update the total label with the selected date and calculated total
                lblTotal.Text = $"Total Sales Amount of {selectedDate.ToString("d")} is = {totalPrice:C}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching sales data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}