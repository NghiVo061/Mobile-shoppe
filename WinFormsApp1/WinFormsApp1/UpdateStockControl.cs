using System;
using System.Data.SqlClient; // Chuyển sang System.Data.SqlClient
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class UpdateStockControl : UserControl
    {
        private string connectionString = @"Server=RANG_DONG\MSSQLSERVER01;Database=MobileShopedb;Integrated Security=True;Encrypt=False;";

        public UpdateStockControl()
        {
            InitializeComponent();
            LoadCompanies(); // Load danh sách công ty khi UserControl khởi tạo
            LoadLatestTransId(); // Load giá trị TransId tiếp theo

            // Vô hiệu hóa TextBox Trans ID vì nó sẽ được sinh tự động
            txtTransID.Enabled = false;
        }

        // Load giá trị TransId tiếp theo từ tbl_Transaction
        private void LoadLatestTransId()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(TransId), 0) + 1 FROM tbl_Transaction", conn);
                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        int nextTransId = Convert.ToInt32(result);
                        txtTransID.Text = nextTransId.ToString(); // Hiển thị TransId tiếp theo
                    }
                    else
                    {
                        txtTransID.Text = "1"; // Nếu bảng rỗng, hiển thị giá trị khởi đầu là 1
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải Trans ID: " + ex.Message);
                    txtTransID.Text = "1"; // Giá trị mặc định nếu có lỗi
                }
            }
        }

        // Load danh sách Company Name vào cboCompanyName
        private void LoadCompanies()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT CName FROM tbl_Company", conn);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cboCompanyName.Items.Add(reader["CName"]?.ToString() ?? string.Empty);
                    }
                    reader.Close();

                    // Không tự động chọn công ty đầu tiên
                    // Bỏ dòng: cboCompanyName.SelectedIndex = 0;
                    // Bỏ gọi LoadModelsByCompany tại đây
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải danh sách công ty: " + ex.Message);
                }
            }

            // Gán sự kiện cho cboCompanyName để load models khi chọn công ty
            cboCompanyName.SelectedIndexChanged += (s, e) =>
            {
                string companyName = cboCompanyName.SelectedItem?.ToString() ?? string.Empty;
                LoadModelsByCompany(companyName);
            };
        }

        // Load danh sách Model Number dựa trên Company Name
        private void LoadModelsByCompany(string companyName)
        {
            cboModelNumber.Items.Clear();

            if (string.IsNullOrEmpty(companyName))
                return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT ModelNum " +
                    "FROM tbl_Model m " +
                    "JOIN tbl_Company c ON m.CompId = c.CompId " +
                    "WHERE c.CName = @CName", conn);
                cmd.Parameters.AddWithValue("@CName", companyName);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cboModelNumber.Items.Add(reader["ModelNum"]?.ToString() ?? string.Empty);
                    }
                    reader.Close();

                    if (cboModelNumber.Items.Count > 0)
                        cboModelNumber.SelectedIndex = 0; // Chọn model đầu tiên khi có dữ liệu
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải danh sách model: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string companyName = cboCompanyName.SelectedItem?.ToString() ?? string.Empty;
            string modelNumber = cboModelNumber.SelectedItem?.ToString() ?? string.Empty;
            string quantity = txtQuantity.Text;
            string amount = txtAmount.Text;

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(companyName) || string.IsNullOrEmpty(modelNumber) ||
                string.IsNullOrEmpty(quantity) || string.IsNullOrEmpty(amount))
            {
                MessageBox.Show("Vui lòng điền đầy đủ các trường.");
                return;
            }

            // Kiểm tra quantity và amount có phải là số hợp lệ không
            if (!int.TryParse(quantity, out int qty) || qty <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên dương.");
                return;
            }

            if (!decimal.TryParse(amount, out decimal amt) || amt <= 0)
            {
                MessageBox.Show("Số tiền phải là số hợp lệ và lớn hơn 0.");
                return;
            }

            // Cập nhật dữ liệu vào bảng tbl_Transaction
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Lấy ModelId dựa trên ModelNum và CName
                    SqlCommand cmdGetModelId = new SqlCommand(
                        "SELECT m.ModelId " +
                        "FROM tbl_Model m " +
                        "JOIN tbl_Company c ON m.CompId = c.CompId " +
                        "WHERE m.ModelNum = @ModelNum AND c.CName = @CName", conn);
                    cmdGetModelId.Parameters.AddWithValue("@ModelNum", modelNumber);
                    cmdGetModelId.Parameters.AddWithValue("@CName", companyName);

                    object modelIdObj = cmdGetModelId.ExecuteScalar();
                    if (modelIdObj == null)
                    {
                        MessageBox.Show("Không tìm thấy ModelId tương ứng.");
                        return;
                    }
                    int modelId = Convert.ToInt32(modelIdObj);

                    // Chèn vào tbl_Transaction (TransId tự động sinh)
                    SqlCommand cmdInsert = new SqlCommand(
                        "INSERT INTO tbl_Transaction (ModelId, Quantity, Date, Amount) " +
                        "VALUES (@ModelId, @Quantity, @Date, @Amount); " +
                        "SELECT SCOPE_IDENTITY();", conn); // Lấy TransId vừa chèn
                    cmdInsert.Parameters.AddWithValue("@ModelId", modelId);
                    cmdInsert.Parameters.AddWithValue("@Quantity", qty);
                    cmdInsert.Parameters.AddWithValue("@Date", DateTime.Now);
                    cmdInsert.Parameters.AddWithValue("@Amount", amt);

                    // Lấy TransId vừa chèn
                    decimal newTransId = Convert.ToDecimal(cmdInsert.ExecuteScalar());
                    // Cập nhật TransId trên giao diện (giá trị tiếp theo)
                    txtTransID.Text = (newTransId + 1).ToString();

                    // Cập nhật AvailableQty trong tbl_Model
                    SqlCommand cmdUpdateQty = new SqlCommand(
                        "UPDATE tbl_Model " +
                        "SET AvailableQty = ISNULL(AvailableQty, 0) + @Quantity " +
                        "WHERE ModelId = @ModelId", conn);
                    cmdUpdateQty.Parameters.AddWithValue("@Quantity", qty);
                    cmdUpdateQty.Parameters.AddWithValue("@ModelId", modelId);
                    cmdUpdateQty.ExecuteNonQuery();

                    MessageBox.Show("Cập nhật kho thành công!");

                    // Xóa các trường Quantity và Amount sau khi update thành công
                    txtQuantity.Text = "";
                    txtAmount.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật kho: " + ex.Message);
                }
            }
        }

        private void UpdateStockControl_Load(object sender, EventArgs e)
        {

        }
    }
}