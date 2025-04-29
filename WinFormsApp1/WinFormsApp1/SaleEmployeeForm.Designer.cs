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
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            comboCompanyName = new ComboBox();
            comboModelNo = new ComboBox();
            comboIMEI = new ComboBox();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(435, 23);
            labelTitle.Margin = new Padding(2, 0, 2, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(99, 45);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Sales";
            // 
            // labelCustomerName
            // 
            labelCustomerName.AutoSize = true;
            labelCustomerName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCustomerName.Location = new Point(96, 102);
            labelCustomerName.Margin = new Padding(2, 0, 2, 0);
            labelCustomerName.Name = "labelCustomerName";
            labelCustomerName.Size = new Size(153, 28);
            labelCustomerName.TabIndex = 1;
            labelCustomerName.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerName.Location = new Point(349, 102);
            txtCustomerName.Margin = new Padding(2);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(402, 34);
            txtCustomerName.TabIndex = 2;
            txtCustomerName.TextChanged += txtCustomerName_TextChanged;
            // 
            // labelMobileNumber
            // 
            labelMobileNumber.AutoSize = true;
            labelMobileNumber.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMobileNumber.Location = new Point(102, 148);
            labelMobileNumber.Margin = new Padding(2, 0, 2, 0);
            labelMobileNumber.Name = "labelMobileNumber";
            labelMobileNumber.Size = new Size(151, 28);
            labelMobileNumber.TabIndex = 3;
            labelMobileNumber.Text = "Mobile Number";
            // 
            // txtMobileNumber
            // 
            txtMobileNumber.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMobileNumber.Location = new Point(349, 148);
            txtMobileNumber.Margin = new Padding(2);
            txtMobileNumber.Name = "txtMobileNumber";
            txtMobileNumber.Size = new Size(402, 34);
            txtMobileNumber.TabIndex = 4;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAddress.Location = new Point(130, 198);
            labelAddress.Margin = new Padding(2, 0, 2, 0);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(82, 28);
            labelAddress.TabIndex = 5;
            labelAddress.Text = "Address";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(130, 246);
            labelEmail.Margin = new Padding(2, 0, 2, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(83, 28);
            labelEmail.TabIndex = 7;
            labelEmail.Text = "Email ID";
            // 
            // labelCompanyName
            // 
            labelCompanyName.AutoSize = true;
            labelCompanyName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCompanyName.Location = new Point(104, 289);
            labelCompanyName.Margin = new Padding(2, 0, 2, 0);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new Size(153, 28);
            labelCompanyName.TabIndex = 9;
            labelCompanyName.Text = "Company Name";
            // 
            // labelModelNumber
            // 
            labelModelNumber.AutoSize = true;
            labelModelNumber.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelModelNumber.Location = new Point(112, 343);
            labelModelNumber.Margin = new Padding(2, 0, 2, 0);
            labelModelNumber.Name = "labelModelNumber";
            labelModelNumber.Size = new Size(146, 28);
            labelModelNumber.TabIndex = 11;
            labelModelNumber.Text = "Model Number";
            // 
            // labelIMEI
            // 
            labelIMEI.AutoSize = true;
            labelIMEI.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelIMEI.Location = new Point(124, 396);
            labelIMEI.Margin = new Padding(2, 0, 2, 0);
            labelIMEI.Name = "labelIMEI";
            labelIMEI.Size = new Size(127, 28);
            labelIMEI.TabIndex = 13;
            labelIMEI.Text = "IMEI Number";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrice.Location = new Point(158, 458);
            labelPrice.Margin = new Padding(2, 0, 2, 0);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(54, 28);
            labelPrice.TabIndex = 15;
            labelPrice.Text = "Price";
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(481, 535);
            btnSubmit.Margin = new Padding(2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(155, 79);
            btnSubmit.TabIndex = 17;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(349, 455);
            txtPrice.Margin = new Padding(2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(402, 34);
            txtPrice.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(349, 241);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(402, 34);
            txtEmail.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(349, 198);
            txtAddress.Margin = new Padding(2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(402, 34);
            txtAddress.TabIndex = 6;
            // 
            // comboCompanyName
            // 
            comboCompanyName.FormattingEnabled = true;
            comboCompanyName.Location = new Point(349, 289);
            comboCompanyName.Name = "comboCompanyName";
            comboCompanyName.Size = new Size(402, 33);
            comboCompanyName.TabIndex = 18;
            comboCompanyName.SelectedIndexChanged += comboCompanyName_SelectedIndexChanged;
            // 
            // comboModelNo
            // 
            comboModelNo.FormattingEnabled = true;
            comboModelNo.Location = new Point(349, 338);
            comboModelNo.Name = "comboModelNo";
            comboModelNo.Size = new Size(402, 33);
            comboModelNo.TabIndex = 19;
            comboModelNo.SelectedIndexChanged += comboModelNo_SelectedIndexChanged;
            // 
            // comboIMEI
            // 
            comboIMEI.FormattingEnabled = true;
            comboIMEI.Location = new Point(349, 391);
            comboIMEI.Name = "comboIMEI";
            comboIMEI.Size = new Size(402, 33);
            comboIMEI.TabIndex = 20;
            comboIMEI.SelectedIndexChanged += comboIMEI_SelectedIndexChanged;
            // 
            // SaleEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboIMEI);
            Controls.Add(comboModelNo);
            Controls.Add(comboCompanyName);
            Controls.Add(btnSubmit);
            Controls.Add(txtPrice);
            Controls.Add(labelPrice);
            Controls.Add(labelIMEI);
            Controls.Add(labelModelNumber);
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
            Margin = new Padding(2);
            Name = "SaleEmployeeForm";
            Size = new Size(953, 770);
            Load += SaleEmployeeForm_Load;
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
        private TextBox txtEmail;
        private TextBox txtAddress;
        private ComboBox comboCompanyName;
        private ComboBox comboModelNo;
        private ComboBox comboIMEI;
    }
}