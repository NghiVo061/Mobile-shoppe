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
            txtCustomerName = new TextBox();
            labelMobileNumber = new Label();
            txtMobileNumber = new TextBox();
            labelAddress = new Label();
            labelEmail = new Label();
            labelCompanyName = new Label();
            labelModelNumber = new Label();
            labelIMEI = new Label();
            labelPrice = new Label();
            btnSubmit = new Button();
            txtPrice = new TextBox();
            txtIMEI = new TextBox();
            txtModelNumber = new TextBox();
            txtCompanyName = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(566, 30);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(126, 59);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Sales";
            // 
            // labelCustomerName
            // 
            labelCustomerName.AutoSize = true;
            labelCustomerName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCustomerName.Location = new Point(125, 130);
            labelCustomerName.Name = "labelCustomerName";
            labelCustomerName.Size = new Size(209, 37);
            labelCustomerName.TabIndex = 1;
            labelCustomerName.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerName.Location = new Point(454, 130);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(522, 43);
            txtCustomerName.TabIndex = 2;
            txtCustomerName.TextChanged += txtCustomerName_TextChanged;
            // 
            // labelMobileNumber
            // 
            labelMobileNumber.AutoSize = true;
            labelMobileNumber.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMobileNumber.Location = new Point(133, 189);
            labelMobileNumber.Name = "labelMobileNumber";
            labelMobileNumber.Size = new Size(205, 37);
            labelMobileNumber.TabIndex = 3;
            labelMobileNumber.Text = "Mobile Number";
            // 
            // txtMobileNumber
            // 
            txtMobileNumber.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMobileNumber.Location = new Point(454, 189);
            txtMobileNumber.Name = "txtMobileNumber";
            txtMobileNumber.Size = new Size(522, 43);
            txtMobileNumber.TabIndex = 4;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAddress.Location = new Point(169, 253);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(111, 37);
            labelAddress.TabIndex = 5;
            labelAddress.Text = "Address";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(169, 315);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(115, 37);
            labelEmail.TabIndex = 7;
            labelEmail.Text = "Email ID";
            // 
            // labelCompanyName
            // 
            labelCompanyName.AutoSize = true;
            labelCompanyName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCompanyName.Location = new Point(135, 370);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new Size(209, 37);
            labelCompanyName.TabIndex = 9;
            labelCompanyName.Text = "Company Name";
            // 
            // labelModelNumber
            // 
            labelModelNumber.AutoSize = true;
            labelModelNumber.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelModelNumber.Location = new Point(146, 439);
            labelModelNumber.Name = "labelModelNumber";
            labelModelNumber.Size = new Size(198, 37);
            labelModelNumber.TabIndex = 11;
            labelModelNumber.Text = "Model Number";
            // 
            // labelIMEI
            // 
            labelIMEI.AutoSize = true;
            labelIMEI.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelIMEI.Location = new Point(161, 507);
            labelIMEI.Name = "labelIMEI";
            labelIMEI.Size = new Size(173, 37);
            labelIMEI.TabIndex = 13;
            labelIMEI.Text = "IMEI Number";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrice.Location = new Point(206, 586);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(74, 37);
            labelPrice.TabIndex = 15;
            labelPrice.Text = "Price";
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(625, 685);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(202, 101);
            btnSubmit.TabIndex = 17;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(454, 583);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(522, 43);
            txtPrice.TabIndex = 16;
            // 
            // txtIMEI
            // 
            txtIMEI.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIMEI.Location = new Point(454, 507);
            txtIMEI.Name = "txtIMEI";
            txtIMEI.Size = new Size(522, 43);
            txtIMEI.TabIndex = 14;
            // 
            // txtModelNumber
            // 
            txtModelNumber.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtModelNumber.Location = new Point(454, 439);
            txtModelNumber.Name = "txtModelNumber";
            txtModelNumber.Size = new Size(522, 43);
            txtModelNumber.TabIndex = 12;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCompanyName.Location = new Point(454, 370);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(522, 43);
            txtCompanyName.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(454, 309);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(522, 43);
            txtEmail.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(454, 253);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(522, 43);
            txtAddress.TabIndex = 6;
            // 
            // SaleEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSubmit);
            Controls.Add(txtPrice);
            Controls.Add(labelPrice);
            Controls.Add(txtIMEI);
            Controls.Add(labelIMEI);
            Controls.Add(txtModelNumber);
            Controls.Add(labelModelNumber);
            Controls.Add(txtCompanyName);
            Controls.Add(labelCompanyName);
            Controls.Add(txtEmail);
            Controls.Add(labelEmail);
            Controls.Add(txtAddress);
            Controls.Add(labelAddress);
            Controls.Add(txtMobileNumber);
            Controls.Add(labelMobileNumber);
            Controls.Add(txtCustomerName);
            Controls.Add(labelCustomerName);
            Controls.Add(labelTitle);
            Name = "SaleEmployeeForm";
            Size = new Size(1239, 985);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label labelMobileNumber;
        private System.Windows.Forms.TextBox txtMobileNumber;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label labelModelNumber;
        private System.Windows.Forms.Label labelIMEI;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button btnSubmit;
        private TextBox txtPrice;
        private TextBox txtIMEI;
        private TextBox txtModelNumber;
        private TextBox txtCompanyName;
        private TextBox txtEmail;
        private TextBox txtAddress;
    }
}