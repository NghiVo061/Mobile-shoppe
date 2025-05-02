namespace WinFormsApp1
{
    partial class AddEmployeeControl
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtEmpName = new TextBox();
            txtAddress = new TextBox();
            txtMobile = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtRetypePassword = new TextBox();
            txtHint = new TextBox();
            btnAddEmployee = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 0;
            label1.Text = "Employee Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 105);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 1;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 174);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 2;
            label3.Text = "Mobile";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 231);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 3;
            label4.Text = "User Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(90, 301);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(90, 365);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(146, 25);
            label6.TabIndex = 5;
            label6.Text = "Retype Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(90, 424);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(45, 25);
            label7.TabIndex = 6;
            label7.Text = "Hint";
            // 
            // txtEmpName
            // 
            txtEmpName.Location = new Point(289, 39);
            txtEmpName.Margin = new Padding(4, 4, 4, 4);
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(155, 31);
            txtEmpName.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(289, 105);
            txtAddress.Margin = new Padding(4, 4, 4, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(155, 31);
            txtAddress.TabIndex = 8;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(289, 174);
            txtMobile.Margin = new Padding(4, 4, 4, 4);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(155, 31);
            txtMobile.TabIndex = 9;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(289, 231);
            txtUsername.Margin = new Padding(4, 4, 4, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(155, 31);
            txtUsername.TabIndex = 10;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(289, 292);
            txtPassword.Margin = new Padding(4, 4, 4, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(155, 31);
            txtPassword.TabIndex = 11;
            // 
            // txtRetypePassword
            // 
            txtRetypePassword.Location = new Point(289, 356);
            txtRetypePassword.Margin = new Padding(4, 4, 4, 4);
            txtRetypePassword.Name = "txtRetypePassword";
            txtRetypePassword.Size = new Size(155, 31);
            txtRetypePassword.TabIndex = 12;
            // 
            // txtHint
            // 
            txtHint.Location = new Point(289, 424);
            txtHint.Margin = new Padding(4, 4, 4, 4);
            txtHint.Name = "txtHint";
            txtHint.Size = new Size(155, 31);
            txtHint.TabIndex = 13;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(142, 500);
            btnAddEmployee.Margin = new Padding(4, 4, 4, 4);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(166, 52);
            btnAddEmployee.TabIndex = 14;
            btnAddEmployee.Text = "Add";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click_1;
            // 
            // AddEmployeeControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAddEmployee);
            Controls.Add(txtHint);
            Controls.Add(txtRetypePassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtMobile);
            Controls.Add(txtAddress);
            Controls.Add(txtEmpName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "AddEmployeeControl";
            Size = new Size(708, 592);
            Load += AddEmployeeControl_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtEmpName;
        private TextBox txtAddress;
        private TextBox txtMobile;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtRetypePassword;
        private TextBox txtHint;
        private Button btnAddEmployee;
    }
}
