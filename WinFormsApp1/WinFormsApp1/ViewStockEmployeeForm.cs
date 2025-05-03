using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WinFormsApp1
{
    public partial class ViewStockEmployeeForm : UserControl
    {
        private string connectionString = @"Server=RANG_DONG\MSSQLSERVER01;Database=MobileShopedb;Integrated Security=True;Encrypt=False;";
        private bool isModelLoaded = false;

        public ViewStockEmployeeForm()
        {
            InitializeComponent();
        }

        private void ViewStockEmployeeForm_Load(object sender, EventArgs e)
        {
            LoadCompanyNames();
            txtAvaib.ReadOnly = true;
        }

        private void LoadCompanyNames()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT CompId, CName FROM tbl_Company", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cboCompanyName.DataSource = dt;
                    cboCompanyName.DisplayMember = "CName";
                    cboCompanyName.ValueMember = "CompId";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading companies: " + ex.Message);
            }
        }

        private void comboCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadModelNumbers();
        }

        private void LoadModelNumbers()
        {
            try
            {
                if (cboCompanyName.SelectedValue != null)
                {
                    string compId = cboCompanyName.SelectedValue.ToString();

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("SELECT ModelId, ModelNum FROM tbl_Model WHERE CompId = @compId", conn);
                        cmd.Parameters.AddWithValue("@compId", compId);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cboModelNo.SelectedIndexChanged -= comboModelNo_SelectedIndexChanged;
                        cboModelNo.DataSource = dt;
                        cboModelNo.DisplayMember = "ModelNum";
                        cboModelNo.ValueMember = "ModelId";

                        if (dt.Rows.Count > 0)
                        {
                            cboModelNo.SelectedIndex = 0;
                            LoadAvailableQty(); 
                        }
                        else
                        {
                            cboModelNo.SelectedIndex = -1;
                            txtAvaib.Text = "0"; 
                        }

                        cboModelNo.SelectedIndexChanged += comboModelNo_SelectedIndexChanged;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading models: " + ex.Message);
            }
        }



        private void comboModelNo_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (isModelLoaded) 
            {
                LoadAvailableQty();
            }
        }

        private void LoadAvailableQty()
        {
            try
            {
                if (cboModelNo.SelectedValue != null && int.TryParse(cboModelNo.SelectedValue.ToString(), out int modelId))
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("SELECT AvailableQty FROM tbl_Model WHERE ModelId = @modelId", conn);
                        cmd.Parameters.AddWithValue("@modelId", modelId);
                        object result = cmd.ExecuteScalar();
                        txtAvaib.Text = result?.ToString() ?? "0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stock: " + ex.Message);
            }
        }
    }

}
