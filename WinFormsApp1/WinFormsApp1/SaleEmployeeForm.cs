using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WinFormsApp1
{
    public partial class SaleEmployeeForm : UserControl
    {
        private string connectionString = @"Server=RANG_DONG\MSSQLSERVER01;Database=MobileShopedb;Integrated Security=True;Encrypt=False;";

        public SaleEmployeeForm()
        {
            InitializeComponent();
        }

        private void SaleEmployeeForm_Load(object sender, EventArgs e)
        {
            LoadCompanyNames();
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
                    cboCompanyName.ValueMember = "CompId"; // Phải có CompId
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading company names: " + ex.Message);
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
                    string selectedCompId = cboCompanyName.SelectedValue.ToString();

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("SELECT ModelNum FROM tbl_Model WHERE CompId = @compId", conn);
                        cmd.Parameters.AddWithValue("@compId", selectedCompId);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cboModelNo.DataSource = dt;
                        cboModelNo.DisplayMember = "ModelNum";
                        cboModelNo.ValueMember = "ModelNum";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading model numbers: " + ex.Message);
            }
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Insert vào bảng Customer và lấy CustId mới sinh ra
                    SqlCommand cmdCustomer = new SqlCommand(
                        "INSERT INTO tbl_Customer (Cust_Name, MobileNumber, Address, EmailId) OUTPUT INSERTED.CustId " +
                        "VALUES (@name, @mobile, @address, @email)", conn);

                    cmdCustomer.Parameters.AddWithValue("@name", txtCusName.Text);
                    cmdCustomer.Parameters.AddWithValue("@mobile", txtMblNumber.Text);
                    cmdCustomer.Parameters.AddWithValue("@address", txtAddr.Text);
                    cmdCustomer.Parameters.AddWithValue("@email", txtEmail.Text);

                    int customerId = (int)cmdCustomer.ExecuteScalar();

                    // Insert vào bảng Sales
                    SqlCommand cmdSale = new SqlCommand(
        "INSERT INTO tbl_Sales (CustId, IMEINo, Price) " +
        "VALUES (@custid, @imei, @price)", conn);

                    cmdSale.Parameters.AddWithValue("@custid", customerId);
                    cmdSale.Parameters.AddWithValue("@imei", cboIMEI.Text);
                    cmdSale.Parameters.AddWithValue("@price", decimal.Parse(txtprice.Text));


                    cmdSale.ExecuteNonQuery();

                    MessageBox.Show("Sales entry successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtCusName.Text) ||
                string.IsNullOrWhiteSpace(txtMblNumber.Text) ||
                string.IsNullOrWhiteSpace(txtAddr.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(cboIMEI.Text) ||
                string.IsNullOrWhiteSpace(txtprice.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cboIMEI.Text.Length != 15)
            {
                MessageBox.Show("IMEI must have exactly 15 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            txtCusName.Clear();
            txtMblNumber.Clear();
            txtAddr.Clear();
            txtEmail.Clear();
            cboIMEI.DataSource = null;
            cboIMEI.Items.Clear();
            cboIMEI.Text = "";

            txtprice.Clear();
            cboCompanyName.SelectedIndex = -1;
            cboModelNo.DataSource = null;
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            // Không cần code ở đây
        }

        private void txtIMEI_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboModelNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIMEINumbers();
        }

        private void comboIMEI_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void LoadIMEINumbers()
        {
            try
            {
                if (cboModelNo.SelectedValue != null)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        // Model Number là giá trị từ comboModelNo.Text
                        string selectedModelNo = cboModelNo.Text;

                        // Truy vấn đúng với bảng tbl_Model
                        SqlCommand cmdGetModelId = new SqlCommand(
                            "SELECT ModelId FROM tbl_Model WHERE ModelNum = @modelNum", conn);
                        cmdGetModelId.Parameters.AddWithValue("@modelNum", selectedModelNo);

                        object modelIdObj = cmdGetModelId.ExecuteScalar();
                        if (modelIdObj != null)
                        {
                            int modelId = Convert.ToInt32(modelIdObj);

                            // Bây giờ lấy IMEI từ tbl_Mobile dựa trên ModelId
                            SqlCommand cmd = new SqlCommand(
                                "SELECT IMEINO FROM tbl_Mobile WHERE ModelId = @modelId", conn);
                            cmd.Parameters.AddWithValue("@modelId", modelId);

                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            cboIMEI.DataSource = dt;
                            cboIMEI.DisplayMember = "IMEINO";
                            cboIMEI.ValueMember = "IMEINO";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading IMEI numbers: " + ex.Message);
            }
        }
    }
}
