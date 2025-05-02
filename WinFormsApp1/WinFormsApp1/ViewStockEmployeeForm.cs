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
            txtAvailable.ReadOnly = true;
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

                    comboCompanyName.DataSource = dt;
                    comboCompanyName.DisplayMember = "CName";
                    comboCompanyName.ValueMember = "CompId";
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
                if (comboCompanyName.SelectedValue != null && int.TryParse(comboCompanyName.SelectedValue.ToString(), out int compId))
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("SELECT ModelId, ModelNum FROM tbl_Model WHERE CompId = @compId", conn);
                        cmd.Parameters.AddWithValue("@compId", compId);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        comboModelNo.SelectedIndexChanged -= comboModelNo_SelectedIndexChanged; // Tạm ngắt sự kiện
                        comboModelNo.DataSource = dt;
                        comboModelNo.DisplayMember = "ModelNum";
                        comboModelNo.ValueMember = "ModelId";
                        comboModelNo.SelectedIndex = 0; // chọn dòng đầu tiên
                        comboModelNo.SelectedIndexChanged += comboModelNo_SelectedIndexChanged; // gắn lại sự kiện

                        LoadAvailableQty(); // gọi trực tiếp để hiển thị luôn
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
            if (isModelLoaded) // 👈 Chỉ gọi khi đã load xong danh sách
            {
                LoadAvailableQty();
            }
        }

        private void LoadAvailableQty()
        {
            try
            {
                if (comboModelNo.SelectedValue != null && int.TryParse(comboModelNo.SelectedValue.ToString(), out int modelId))
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("SELECT AvailableQty FROM tbl_Model WHERE ModelId = @modelId", conn);
                        cmd.Parameters.AddWithValue("@modelId", modelId);
                        object result = cmd.ExecuteScalar();
                        txtAvailable.Text = result?.ToString() ?? "0";
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
