namespace WinFormsApp1
{
    partial class Employee
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSales = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblMobileNumber = new System.Windows.Forms.Label();
            this.txtMobileNumber = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblModelNumber = new System.Windows.Forms.Label();
            this.txtModelNumber = new System.Windows.Forms.TextBox();
            this.lblImeiNumber = new System.Windows.Forms.Label();
            this.txtImeiNumber = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(112, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Customers";

            // lblSales
            this.lblSales.AutoSize = true;
            this.lblSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSales.Location = new System.Drawing.Point(20, 60);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(52, 20);
            this.lblSales.TabIndex = 1;
            this.lblSales.Text = "Sales";

            // lblCustomerName
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(50, 100);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(85, 13);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Customer Name:";

            // txtCustomerName
            this.txtCustomerName.Location = new System.Drawing.Point(150, 97);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(200, 20);
            this.txtCustomerName.TabIndex = 3;

            // lblMobileNumber
            this.lblMobileNumber.AutoSize = true;
            this.lblMobileNumber.Location = new System.Drawing.Point(50, 130);
            this.lblMobileNumber.Name = "lblMobileNumber";
            this.lblMobileNumber.Size = new System.Drawing.Size(81, 13);
            this.lblMobileNumber.TabIndex = 4;
            this.lblMobileNumber.Text = "Mobile Number:";

            // txtMobileNumber
            this.txtMobileNumber.Location = new System.Drawing.Point(150, 127);
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(200, 20);
            this.txtMobileNumber.TabIndex = 5;

            // lblAddress
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(50, 160);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address:";

            // txtAddress
            this.txtAddress.Location = new System.Drawing.Point(150, 157);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 20);
            this.txtAddress.TabIndex = 7;

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(50, 190);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email ID:";

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(150, 187);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 9;

            // lblCompanyName
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(50, 220);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(85, 13);
            this.lblCompanyName.TabIndex = 10;
            this.lblCompanyName.Text = "Company Name:";

            // txtCompanyName
            this.txtCompanyName.Location = new System.Drawing.Point(150, 217);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(200, 20);
            this.txtCompanyName.TabIndex = 11;

            // lblModelNumber
            this.lblModelNumber.AutoSize = true;
            this.lblModelNumber.Location = new System.Drawing.Point(50, 250);
            this.lblModelNumber.Name = "lblModelNumber";
            this.lblModelNumber.Size = new System.Drawing.Size(79, 13);
            this.lblModelNumber.TabIndex = 12;
            this.lblModelNumber.Text = "Model Number:";

            // txtModelNumber
            this.txtModelNumber.Location = new System.Drawing.Point(150, 247);
            this.txtModelNumber.Name = "txtModelNumber";
            this.txtModelNumber.Size = new System.Drawing.Size(200, 20);
            this.txtModelNumber.TabIndex = 13;

            // lblImeiNumber
            this.lblImeiNumber.AutoSize = true;
            this.lblImeiNumber.Location = new System.Drawing.Point(50, 280);
            this.lblImeiNumber.Name = "lblImeiNumber";
            this.lblImeiNumber.Size = new System.Drawing.Size(69, 13);
            this.lblImeiNumber.TabIndex = 14;
            this.lblImeiNumber.Text = "IMEI Number:";

            // txtImeiNumber
            this.txtImeiNumber.Location = new System.Drawing.Point(150, 277);
            this.txtImeiNumber.Name = "txtImeiNumber";
            this.txtImeiNumber.Size = new System.Drawing.Size(200, 20);
            this.txtImeiNumber.TabIndex = 15;

            // lblPrice
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(50, 310);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(64, 13);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.Text = "Price/Place:";

            // txtPrice
            this.txtPrice.Location = new System.Drawing.Point(150, 307);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 20);
            this.txtPrice.TabIndex = 17;

            // btnSubmit
            this.btnSubmit.Location = new System.Drawing.Point(150, 350);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 30);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            // Employee
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtImeiNumber);
            this.Controls.Add(this.lblImeiNumber);
            this.Controls.Add(this.txtModelNumber);
            this.Controls.Add(this.lblModelNumber);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtMobileNumber);
            this.Controls.Add(this.lblMobileNumber);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblSales);
            this.Controls.Add(this.lblTitle);
            this.Name = "Employee";
            this.Text = "Employee Form";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblMobileNumber;
        private System.Windows.Forms.TextBox txtMobileNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblModelNumber;
        private System.Windows.Forms.TextBox txtModelNumber;
        private System.Windows.Forms.Label lblImeiNumber;
        private System.Windows.Forms.TextBox txtImeiNumber;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnSubmit;
    }
}