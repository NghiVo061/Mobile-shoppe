namespace WinFormsApp1
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnSearchCusImei = new Button();
            btnViewSt = new Button();
            btnSales = new Button();
            panelContent = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.DimGray;
            panelMenu.Controls.Add(btnSearchCusImei);
            panelMenu.Controls.Add(btnViewSt);
            panelMenu.Controls.Add(btnSales);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(224, 586);
            panelMenu.TabIndex = 0;
            // 
            // btnSearchCusImei
            // 
            btnSearchCusImei.BackColor = Color.White;
            btnSearchCusImei.FlatAppearance.BorderSize = 0;
            btnSearchCusImei.FlatStyle = FlatStyle.Flat;
            btnSearchCusImei.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchCusImei.ForeColor = Color.Black;
            btnSearchCusImei.Location = new Point(32, 345);
            btnSearchCusImei.Margin = new Padding(2);
            btnSearchCusImei.Name = "btnSearchCusImei";
            btnSearchCusImei.Size = new Size(139, 67);
            btnSearchCusImei.TabIndex = 2;
            btnSearchCusImei.Text = "SearchCustomerbyMEI";
            btnSearchCusImei.UseVisualStyleBackColor = false;
            btnSearchCusImei.Click += btnSearchCustomer_Click;
            // 
            // btnViewSt
            // 
            btnViewSt.BackColor = Color.White;
            btnViewSt.FlatAppearance.BorderSize = 0;
            btnViewSt.FlatStyle = FlatStyle.Flat;
            btnViewSt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewSt.ForeColor = Color.Black;
            btnViewSt.Location = new Point(32, 197);
            btnViewSt.Margin = new Padding(2);
            btnViewSt.Name = "btnViewSt";
            btnViewSt.Size = new Size(139, 64);
            btnViewSt.TabIndex = 1;
            btnViewSt.Text = "ViewStock";
            btnViewSt.UseVisualStyleBackColor = false;
            btnViewSt.Click += btnViewStock_Click;
            // 
            // btnSales
            // 
            btnSales.BackColor = Color.White;
            btnSales.FlatAppearance.BorderSize = 0;
            btnSales.FlatStyle = FlatStyle.Flat;
            btnSales.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSales.ForeColor = Color.Black;
            btnSales.Location = new Point(32, 55);
            btnSales.Margin = new Padding(2);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(139, 61);
            btnSales.TabIndex = 0;
            btnSales.Text = "Sale";
            btnSales.UseVisualStyleBackColor = false;
            btnSales.Click += btnSale_Click;
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(224, 0);
            panelContent.Margin = new Padding(2);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(736, 586);
            panelContent.TabIndex = 1;
            panelContent.Paint += panelContent_Paint;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 586);
            Controls.Add(panelContent);
            Controls.Add(panelMenu);
            Margin = new Padding(2);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnSearchCusImei;
        private Button btnViewSt;
        private Button btnSales;
        private Panel panelContent;
    }
}