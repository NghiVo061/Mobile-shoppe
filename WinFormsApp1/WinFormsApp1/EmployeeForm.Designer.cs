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
            btnSearchCustomer = new Button();
            btnViewStock = new Button();
            btnSale = new Button();
            panelContent = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.DimGray;
            panelMenu.Controls.Add(btnSearchCustomer);
            panelMenu.Controls.Add(btnViewStock);
            panelMenu.Controls.Add(btnSale);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(2, 2, 2, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(280, 732);
            panelMenu.TabIndex = 0;
            // 
            // btnSearchCustomer
            // 
            btnSearchCustomer.BackColor = Color.White;
            btnSearchCustomer.FlatAppearance.BorderSize = 0;
            btnSearchCustomer.FlatStyle = FlatStyle.Flat;
            btnSearchCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchCustomer.ForeColor = Color.Black;
            btnSearchCustomer.Location = new Point(40, 431);
            btnSearchCustomer.Margin = new Padding(2, 2, 2, 2);
            btnSearchCustomer.Name = "btnSearchCustomer";
            btnSearchCustomer.Size = new Size(174, 84);
            btnSearchCustomer.TabIndex = 2;
            btnSearchCustomer.Text = "SearchCustomerbyMEI";
            btnSearchCustomer.UseVisualStyleBackColor = false;
            btnSearchCustomer.Click += btnSearchCustomer_Click;
            // 
            // btnViewStock
            // 
            btnViewStock.BackColor = Color.White;
            btnViewStock.FlatAppearance.BorderSize = 0;
            btnViewStock.FlatStyle = FlatStyle.Flat;
            btnViewStock.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewStock.ForeColor = Color.Black;
            btnViewStock.Location = new Point(40, 246);
            btnViewStock.Margin = new Padding(2, 2, 2, 2);
            btnViewStock.Name = "btnViewStock";
            btnViewStock.Size = new Size(174, 80);
            btnViewStock.TabIndex = 1;
            btnViewStock.Text = "ViewStock";
            btnViewStock.UseVisualStyleBackColor = false;
            btnViewStock.Click += btnViewStock_Click;
            // 
            // btnSale
            // 
            btnSale.BackColor = Color.White;
            btnSale.FlatAppearance.BorderSize = 0;
            btnSale.FlatStyle = FlatStyle.Flat;
            btnSale.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSale.ForeColor = Color.Black;
            btnSale.Location = new Point(40, 69);
            btnSale.Margin = new Padding(2, 2, 2, 2);
            btnSale.Name = "btnSale";
            btnSale.Size = new Size(174, 76);
            btnSale.TabIndex = 0;
            btnSale.Text = "Sale";
            btnSale.UseVisualStyleBackColor = false;
            btnSale.Click += btnSale_Click;
            // 
            // panelContent
            // 
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(280, 0);
            panelContent.Margin = new Padding(2, 2, 2, 2);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(920, 732);
            panelContent.TabIndex = 1;
            panelContent.Paint += panelContent_Paint;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 732);
            Controls.Add(panelContent);
            Controls.Add(panelMenu);
            Margin = new Padding(2, 2, 2, 2);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnSearchCustomer;
        private Button btnViewStock;
        private Button btnSale;
        private Panel panelContent;
    }
}