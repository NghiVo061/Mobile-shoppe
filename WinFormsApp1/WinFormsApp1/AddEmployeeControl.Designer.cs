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
            label1.Location = new Point(72, 31);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "Employee Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 84);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 139);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 2;
            label3.Text = "Mobile";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 185);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 3;
            label4.Text = "User Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 241);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(72, 292);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 5;
            label6.Text = "Retype Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(72, 339);
            label7.Name = "label7";
            label7.Size = new Size(37, 20);
            label7.TabIndex = 6;
            label7.Text = "Hint";
            // 
            // txtEmpName
            // 
            txtEmpName.Location = new Point(231, 31);
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(125, 27);
            txtEmpName.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(231, 84);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(125, 27);
            txtAddress.TabIndex = 8;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(231, 139);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(125, 27);
            txtMobile.TabIndex = 9;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(231, 185);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 27);
            txtUsername.TabIndex = 10;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(231, 234);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 11;
            // 
            // txtRetypePassword
            // 
            txtRetypePassword.Location = new Point(231, 285);
            txtRetypePassword.Name = "txtRetypePassword";
            txtRetypePassword.Size = new Size(125, 27);
            txtRetypePassword.TabIndex = 12;
            // 
            // txtHint
            // 
            txtHint.Location = new Point(231, 339);
            txtHint.Name = "txtHint";
            txtHint.Size = new Size(125, 27);
            txtHint.TabIndex = 13;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(114, 400);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(133, 42);
            btnAddEmployee.TabIndex = 14;
            btnAddEmployee.Text = "Add";
            btnAddEmployee.UseVisualStyleBackColor = true;
            // 
            // AddEmployeeControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
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
            Name = "AddEmployeeControl";
            Size = new Size(566, 474);
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
