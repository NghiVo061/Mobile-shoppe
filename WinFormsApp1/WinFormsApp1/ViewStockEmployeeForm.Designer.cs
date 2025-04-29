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
            comboCompanyName = new ComboBox();
            comboModelNo = new ComboBox();
            txtAvailable = new TextBox();
            SuspendLayout();
            // 
            // lblViewStockTitle
            // 
            lblViewStockTitle.AutoSize = true;
            lblViewStockTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblViewStockTitle.Location = new Point(328, 93);
            lblViewStockTitle.Margin = new Padding(2, 0, 2, 0);
            lblViewStockTitle.Name = "lblViewStockTitle";
            lblViewStockTitle.Size = new Size(175, 45);
            lblViewStockTitle.TabIndex = 0;
            lblViewStockTitle.Text = "ViewStock";
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCompanyName.Location = new Point(83, 193);
            lblCompanyName.Margin = new Padding(2, 0, 2, 0);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(263, 32);
            lblCompanyName.TabIndex = 1;
            lblCompanyName.Text = "Select Company Name:";
            // 
            // lblModelNumber
            // 
            lblModelNumber.AutoSize = true;
            lblModelNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblModelNumber.Location = new Point(83, 266);
            lblModelNumber.Margin = new Padding(2, 0, 2, 0);
            lblModelNumber.Name = "lblModelNumber";
            lblModelNumber.Size = new Size(254, 32);
            lblModelNumber.TabIndex = 2;
            lblModelNumber.Text = "Select Model Number:";
            // 
            // lblAvailable
            // 
            lblAvailable.AutoSize = true;
            lblAvailable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvailable.Location = new Point(83, 335);
            lblAvailable.Margin = new Padding(2, 0, 2, 0);
            lblAvailable.Name = "lblAvailable";
            lblAvailable.Size = new Size(186, 32);
            lblAvailable.TabIndex = 3;
            lblAvailable.Text = "Select Available:";
            // 
            // comboCompanyName
            // 
            comboCompanyName.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCompanyName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboCompanyName.FormattingEnabled = true;
            comboCompanyName.Location = new Point(375, 193);
            comboCompanyName.Margin = new Padding(2);
            comboCompanyName.Name = "comboCompanyName";
            comboCompanyName.Size = new Size(347, 36);
            comboCompanyName.TabIndex = 4;
            comboCompanyName.SelectedIndexChanged += comboCompanyName_SelectedIndexChanged;
            // 
            // comboModelNo
            // 
            comboModelNo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboModelNo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboModelNo.FormattingEnabled = true;
            comboModelNo.Location = new Point(375, 266);
            comboModelNo.Margin = new Padding(2);
            comboModelNo.Name = "comboModelNo";
            comboModelNo.Size = new Size(347, 36);
            comboModelNo.TabIndex = 5;
            comboModelNo.SelectedIndexChanged += comboModelNo_SelectedIndexChanged;

            // 
            // txtAvailable
            // 
            txtAvailable.BackColor = SystemColors.Window;
            txtAvailable.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAvailable.Location = new Point(375, 335);
            txtAvailable.Margin = new Padding(2);
            txtAvailable.Name = "txtAvailable";
            txtAvailable.ReadOnly = true;
            txtAvailable.Size = new Size(347, 34);
            txtAvailable.TabIndex = 6;
            // 
            // ViewStockEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtAvailable);
            Controls.Add(comboModelNo);
            Controls.Add(comboCompanyName);
            Controls.Add(lblAvailable);
            Controls.Add(lblModelNumber);
            Controls.Add(lblCompanyName);
            Controls.Add(lblViewStockTitle);
            Margin = new Padding(2);
            Name = "ViewStockEmployeeForm";
            Size = new Size(882, 750);
            Load += ViewStockEmployeeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblViewStockTitle;
        private Label lblCompanyName;
        private Label lblModelNumber;
        private Label lblAvailable;
        private ComboBox comboCompanyName;
        private ComboBox comboModelNo;
        private TextBox txtAvailable;
    }
}