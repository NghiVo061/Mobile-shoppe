namespace WinFormsApp1
{
    partial class ViewStockEmployeeForm
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
            lblViewStockTitle = new Label();
            lblCompanyName = new Label();
            lblModelNumber = new Label();
            lblAvailable = new Label();
            comboBoxCompanyName = new ComboBox();
            comboBoxModelNumber = new ComboBox();
            txtAvailable = new TextBox();
            SuspendLayout();
            // 
            // lblViewStockTitle
            // 
            lblViewStockTitle.AutoSize = true;
            lblViewStockTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblViewStockTitle.Location = new Point(427, 119);
            lblViewStockTitle.Name = "lblViewStockTitle";
            lblViewStockTitle.Size = new Size(234, 59);
            lblViewStockTitle.TabIndex = 0;
            lblViewStockTitle.Text = "ViewStock";
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCompanyName.Location = new Point(108, 247);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(350, 45);
            lblCompanyName.TabIndex = 1;
            lblCompanyName.Text = "Select Company Name:";
            // 
            // lblModelNumber
            // 
            lblModelNumber.AutoSize = true;
            lblModelNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblModelNumber.Location = new Point(108, 340);
            lblModelNumber.Name = "lblModelNumber";
            lblModelNumber.Size = new Size(339, 45);
            lblModelNumber.TabIndex = 2;
            lblModelNumber.Text = "Select Model Number:";
            // 
            // lblAvailable
            // 
            lblAvailable.AutoSize = true;
            lblAvailable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvailable.Location = new Point(108, 429);
            lblAvailable.Name = "lblAvailable";
            lblAvailable.Size = new Size(248, 45);
            lblAvailable.TabIndex = 3;
            lblAvailable.Text = "Select Available:";
            lblAvailable.Click += label3_Click;
            // 
            // comboBoxCompanyName
            // 
            comboBoxCompanyName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCompanyName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxCompanyName.FormattingEnabled = true;
            comboBoxCompanyName.Location = new Point(488, 247);
            comboBoxCompanyName.Name = "comboBoxCompanyName";
            comboBoxCompanyName.Size = new Size(450, 45);
            comboBoxCompanyName.TabIndex = 4;
            // 
            // comboBoxModelNumber
            // 
            comboBoxModelNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxModelNumber.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxModelNumber.FormattingEnabled = true;
            comboBoxModelNumber.Location = new Point(488, 340);
            comboBoxModelNumber.Name = "comboBoxModelNumber";
            comboBoxModelNumber.Size = new Size(450, 45);
            comboBoxModelNumber.TabIndex = 5;
            // 
            // txtAvailable
            // 
            txtAvailable.BackColor = SystemColors.Window;
            txtAvailable.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAvailable.Location = new Point(488, 429);
            txtAvailable.Name = "txtAvailable";
            txtAvailable.ReadOnly = true;
            txtAvailable.Size = new Size(450, 43);
            txtAvailable.TabIndex = 6;
            // 
            // ViewStockEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtAvailable);
            Controls.Add(comboBoxModelNumber);
            Controls.Add(comboBoxCompanyName);
            Controls.Add(lblAvailable);
            Controls.Add(lblModelNumber);
            Controls.Add(lblCompanyName);
            Controls.Add(lblViewStockTitle);
            Name = "ViewStockEmployeeForm";
            Size = new Size(1147, 960);
            Load += ViewStockEmployeeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblViewStockTitle;
        private Label lblCompanyName;
        private Label lblModelNumber;
        private Label lblAvailable;
        private ComboBox comboBoxCompanyName;
        private ComboBox comboBoxModelNumber;
        private TextBox txtAvailable;
    }
}