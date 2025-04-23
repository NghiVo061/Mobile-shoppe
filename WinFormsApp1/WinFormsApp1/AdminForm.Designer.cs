namespace mobileshope
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.Button btnViewSales;
        private System.Windows.Forms.Button btnManageEmployees;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddCompany;
        private System.Windows.Forms.Button btnAddModel;
        private System.Windows.Forms.Button btnAddProductType;
        private System.Windows.Forms.Button btnDaySaleReport;
        private System.Windows.Forms.Button btnDateToDateSaleReport;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAddProductType = new System.Windows.Forms.Button();
            this.btnAddModel = new System.Windows.Forms.Button();
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.btnViewSales = new System.Windows.Forms.Button();
            this.btnManageEmployees = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();

            // panelMenu
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.panelMenu.Controls.Add(this.btnAddProductType);
            this.panelMenu.Controls.Add(this.btnAddModel);
            this.panelMenu.Controls.Add(this.btnAddCompany);
            this.panelMenu.Controls.Add(this.lblTitle);
            this.panelMenu.Controls.Add(this.btnAddProduct);
            this.panelMenu.Controls.Add(this.btnUpdateStock);
            this.panelMenu.Controls.Add(this.btnViewSales);
            this.panelMenu.Controls.Add(this.btnManageEmployees);
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(236, 600);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.Controls.Add(this.btnDaySaleReport);
            this.panelMenu.Controls.Add(this.btnDateToDateSaleReport);


            // btnAddProductType
            this.btnAddProductType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnAddProductType.FlatAppearance.BorderSize = 0;
            this.btnAddProductType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProductType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAddProductType.ForeColor = System.Drawing.Color.White;
            this.btnAddProductType.Location = new System.Drawing.Point(50, 180);
            this.btnAddProductType.Name = "btnAddProductType";
            this.btnAddProductType.Size = new System.Drawing.Size(160, 35);
            this.btnAddProductType.TabIndex = 8;
            this.btnAddProductType.Text = "Mobile";
            this.btnAddProductType.Visible = false;
            this.btnAddProductType.Click += new System.EventHandler(this.btnAddProductType_Click);

            // btnAddModel
            this.btnAddModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnAddModel.FlatAppearance.BorderSize = 0;
            this.btnAddModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddModel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAddModel.ForeColor = System.Drawing.Color.White;
            this.btnAddModel.Location = new System.Drawing.Point(50, 140);
            this.btnAddModel.Name = "btnAddModel";
            this.btnAddModel.Size = new System.Drawing.Size(160, 35);
            this.btnAddModel.TabIndex = 7;
            this.btnAddModel.Text = "Model";
            this.btnAddModel.Visible = false;
            this.btnAddModel.Click += new System.EventHandler(this.btnAddModel_Click);

            // btnAddCompany
            this.btnAddCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnAddCompany.FlatAppearance.BorderSize = 0;
            this.btnAddCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCompany.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAddCompany.ForeColor = System.Drawing.Color.White;
            this.btnAddCompany.Location = new System.Drawing.Point(50, 100);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(160, 35);
            this.btnAddCompany.TabIndex = 6;
            this.btnAddCompany.Text = "Company";
            this.btnAddCompany.Visible = false;
            this.btnAddCompany.Click += new System.EventHandler(this.btnAddCompany_Click);

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(187, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Admin Home";

            // btnAddProduct
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(30, 60);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(180, 40);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "➕ Add";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);

            // btnUpdateStock
            this.btnUpdateStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnUpdateStock.FlatAppearance.BorderSize = 0;
            this.btnUpdateStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStock.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUpdateStock.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStock.Location = new System.Drawing.Point(30, 110);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(180, 40);
            this.btnUpdateStock.TabIndex = 2;
            this.btnUpdateStock.Text = "📦 Update Stock";
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);

            // btnViewSales
            this.btnViewSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnViewSales.FlatAppearance.BorderSize = 0;
            this.btnViewSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSales.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnViewSales.ForeColor = System.Drawing.Color.White;
            this.btnViewSales.Location = new System.Drawing.Point(30, 160);
            this.btnViewSales.Name = "btnViewSales";
            this.btnViewSales.Size = new System.Drawing.Size(180, 40);
            this.btnViewSales.TabIndex = 3;
            this.btnViewSales.Text = "📊 Sale Report";
            this.btnViewSales.Click += new System.EventHandler(this.btnViewSales_Click);

            // btnDaySaleReport
            this.btnDaySaleReport = new System.Windows.Forms.Button();
            this.btnDaySaleReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnDaySaleReport.FlatAppearance.BorderSize = 0;
            this.btnDaySaleReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaySaleReport.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDaySaleReport.ForeColor = System.Drawing.Color.White;
            this.btnDaySaleReport.Location = new System.Drawing.Point(50, 200);  // vị trí điều chỉnh tùy layout
            this.btnDaySaleReport.Name = "btnDaySaleReport";
            this.btnDaySaleReport.Size = new System.Drawing.Size(160, 35);
            this.btnDaySaleReport.TabIndex = 9;
            this.btnDaySaleReport.Text = "Day";
            this.btnDaySaleReport.Visible = false;
            this.btnDaySaleReport.Click += new System.EventHandler(this.btnDaySaleReport_Click);
            this.Controls.Add(this.btnDaySaleReport);

            // btnDateToDateSaleReport
            this.btnDateToDateSaleReport = new System.Windows.Forms.Button();
            this.btnDateToDateSaleReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnDateToDateSaleReport.FlatAppearance.BorderSize = 0;
            this.btnDateToDateSaleReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateToDateSaleReport.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDateToDateSaleReport.ForeColor = System.Drawing.Color.White;
            this.btnDateToDateSaleReport.Location = new System.Drawing.Point(50, 240);  // vị trí điều chỉnh tùy layout
            this.btnDateToDateSaleReport.Name = "btnDateToDateSaleReport";
            this.btnDateToDateSaleReport.Size = new System.Drawing.Size(160, 35);
            this.btnDateToDateSaleReport.TabIndex = 10;
            this.btnDateToDateSaleReport.Text = "Date to Date";
            this.btnDateToDateSaleReport.Visible = false;
            this.btnDateToDateSaleReport.Click += new System.EventHandler(this.btnDateToDateSaleReport_Click);
            this.Controls.Add(this.btnDateToDateSaleReport);



            // btnManageEmployees
            this.btnManageEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnManageEmployees.FlatAppearance.BorderSize = 0;
            this.btnManageEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageEmployees.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnManageEmployees.ForeColor = System.Drawing.Color.White;
            this.btnManageEmployees.Location = new System.Drawing.Point(30, 210);
            this.btnManageEmployees.Name = "btnManageEmployees";
            this.btnManageEmployees.Size = new System.Drawing.Size(180, 40);
            this.btnManageEmployees.TabIndex = 4;
            this.btnManageEmployees.Text = "👥 Employees";
            this.btnManageEmployees.Click += new System.EventHandler(this.btnManageEmployees_Click);

            // btnLogout
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(30, 260);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(180, 40);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "🚪 Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // panelContent
            this.panelContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(236, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(764, 600);
            this.panelContent.TabIndex = 0;

            // AdminForm
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelMenu);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Homepage";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}