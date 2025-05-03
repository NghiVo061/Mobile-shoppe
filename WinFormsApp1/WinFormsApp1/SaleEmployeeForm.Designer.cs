namespace WinFormsApp1
{
    partial class SaleEmployeeForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new Label();
            labelCustomerName = new Label();
            txtCusName = new TextBox();
            labelMobileNumber = new Label();
            txtMblNumber = new TextBox();
            labelAddress = new Label();
            labelEmail = new Label();
            labelCompanyName = new Label();
            labelModelNumber = new Label();
            labelIMEI = new Label();
            labelPrice = new Label();
            btnSub = new Button();
            txtprice = new TextBox();
            txtEmail = new TextBox();
            txtAddr = new TextBox();
            cboCompanyName = new ComboBox();
            cboModelNo = new ComboBox();
            cboIMEI = new ComboBox();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(348, 18);
            labelTitle.Margin = new Padding(2, 0, 2, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(82, 37);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Sales";
            // 
            // labelCustomerName
            // 
            labelCustomerName.AutoSize = true;
            labelCustomerName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCustomerName.Location = new Point(77, 82);
            labelCustomerName.Margin = new Padding(2, 0, 2, 0);
            labelCustomerName.Name = "labelCustomerName";
            labelCustomerName.Size = new Size(135, 23);
            labelCustomerName.TabIndex = 1;
            labelCustomerName.Text = "Customer Name";
            // 
            // txtCusName
            // 
            txtCusName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCusName.Location = new Point(279, 82);
            txtCusName.Margin = new Padding(2);
            txtCusName.Name = "txtCusName";
            txtCusName.Size = new Size(322, 30);
            txtCusName.TabIndex = 2;
            txtCusName.TextChanged += txtCustomerName_TextChanged;
            // 
            // labelMobileNumber
            // 
            labelMobileNumber.AutoSize = true;
            labelMobileNumber.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMobileNumber.Location = new Point(82, 118);
            labelMobileNumber.Margin = new Padding(2, 0, 2, 0);
            labelMobileNumber.Name = "labelMobileNumber";
            labelMobileNumber.Size = new Size(130, 23);
            labelMobileNumber.TabIndex = 3;
            labelMobileNumber.Text = "Mobile Number";
            // 
            // txtMblNumber
            // 
            txtMblNumber.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMblNumber.Location = new Point(279, 118);
            txtMblNumber.Margin = new Padding(2);
            txtMblNumber.Name = "txtMblNumber";
            txtMblNumber.Size = new Size(322, 30);
            txtMblNumber.TabIndex = 4;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAddress.Location = new Point(104, 158);
            labelAddress.Margin = new Padding(2, 0, 2, 0);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(70, 23);
            labelAddress.TabIndex = 5;
            labelAddress.Text = "Address";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(104, 197);
            labelEmail.Margin = new Padding(2, 0, 2, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(73, 23);
            labelEmail.TabIndex = 7;
            labelEmail.Text = "Email ID";
            // 
            // labelCompanyName
            // 
            labelCompanyName.AutoSize = true;
            labelCompanyName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCompanyName.Location = new Point(83, 231);
            labelCompanyName.Margin = new Padding(2, 0, 2, 0);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new Size(134, 23);
            labelCompanyName.TabIndex = 9;
            labelCompanyName.Text = "Company Name";
            // 
            // labelModelNumber
            // 
            labelModelNumber.AutoSize = true;
            labelModelNumber.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelModelNumber.Location = new Point(90, 274);
            labelModelNumber.Margin = new Padding(2, 0, 2, 0);
            labelModelNumber.Name = "labelModelNumber";
            labelModelNumber.Size = new Size(126, 23);
            labelModelNumber.TabIndex = 11;
            labelModelNumber.Text = "Model Number";
            // 
            // labelIMEI
            // 
            labelIMEI.AutoSize = true;
            labelIMEI.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelIMEI.Location = new Point(99, 317);
            labelIMEI.Margin = new Padding(2, 0, 2, 0);
            labelIMEI.Name = "labelIMEI";
            labelIMEI.Size = new Size(112, 23);
            labelIMEI.TabIndex = 13;
            labelIMEI.Text = "IMEI Number";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrice.Location = new Point(126, 366);
            labelPrice.Margin = new Padding(2, 0, 2, 0);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(47, 23);
            labelPrice.TabIndex = 15;
            labelPrice.Text = "Price";
            // 
            // btnSub
            // 
            btnSub.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSub.Location = new Point(385, 428);
            btnSub.Margin = new Padding(2);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(124, 63);
            btnSub.TabIndex = 17;
            btnSub.Text = "SUBMIT";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSubmit_Click;
            // 
            // txtprice
            // 
            txtprice.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtprice.Location = new Point(279, 364);
            txtprice.Margin = new Padding(2);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(322, 30);
            txtprice.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(279, 193);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(322, 30);
            txtEmail.TabIndex = 8;
            // 
            // txtAddr
            // 
            txtAddr.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddr.Location = new Point(279, 158);
            txtAddr.Margin = new Padding(2);
            txtAddr.Name = "txtAddr";
            txtAddr.Size = new Size(322, 30);
            txtAddr.TabIndex = 6;
            // 
            // cboCompanyName
            // 
            cboCompanyName.FormattingEnabled = true;
            cboCompanyName.Location = new Point(279, 231);
            cboCompanyName.Margin = new Padding(2, 2, 2, 2);
            cboCompanyName.Name = "cboCompanyName";
            cboCompanyName.Size = new Size(322, 28);
            cboCompanyName.TabIndex = 18;
            cboCompanyName.SelectedIndexChanged += comboCompanyName_SelectedIndexChanged;
            // 
            // cboModelNo
            // 
            cboModelNo.FormattingEnabled = true;
            cboModelNo.Location = new Point(279, 270);
            cboModelNo.Margin = new Padding(2, 2, 2, 2);
            cboModelNo.Name = "cboModelNo";
            cboModelNo.Size = new Size(322, 28);
            cboModelNo.TabIndex = 19;
            cboModelNo.SelectedIndexChanged += comboModelNo_SelectedIndexChanged;
            // 
            // cboIMEI
            // 
            cboIMEI.FormattingEnabled = true;
            cboIMEI.Location = new Point(279, 313);
            cboIMEI.Margin = new Padding(2, 2, 2, 2);
            cboIMEI.Name = "cboIMEI";
            cboIMEI.Size = new Size(322, 28);
            cboIMEI.TabIndex = 20;
            cboIMEI.SelectedIndexChanged += comboIMEI_SelectedIndexChanged;
            // 
            // SaleEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cboIMEI);
            Controls.Add(cboModelNo);
            Controls.Add(cboCompanyName);
            Controls.Add(btnSub);
            Controls.Add(txtprice);
            Controls.Add(labelPrice);
            Controls.Add(labelIMEI);
            Controls.Add(labelModelNumber);
            Controls.Add(labelCompanyName);
            Controls.Add(txtEmail);
            Controls.Add(labelEmail);
            Controls.Add(txtAddr);
            Controls.Add(labelAddress);
            Controls.Add(txtMblNumber);
            Controls.Add(labelMobileNumber);
            Controls.Add(txtCusName);
            Controls.Add(labelCustomerName);
            Controls.Add(labelTitle);
            Margin = new Padding(2);
            Name = "SaleEmployeeForm";
            Size = new Size(762, 616);
            Load += SaleEmployeeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label labelMobileNumber;
        private System.Windows.Forms.TextBox txtMblNumber;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label labelModelNumber;
        private System.Windows.Forms.Label labelIMEI;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button btnSub;
        private TextBox txtprice;
        private TextBox txtEmail;
        private TextBox txtAddr;
        private ComboBox cboCompanyName;
        private ComboBox cboModelNo;
        private ComboBox cboIMEI;
    }
}