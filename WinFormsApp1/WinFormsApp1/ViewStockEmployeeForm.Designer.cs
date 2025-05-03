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
            cboCompanyName = new ComboBox();
            cboModelNo = new ComboBox();
            txtAvaib = new TextBox();
            SuspendLayout();
            // 
            // lblViewStockTitle
            // 
            lblViewStockTitle.AutoSize = true;
            lblViewStockTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblViewStockTitle.Location = new Point(262, 74);
            lblViewStockTitle.Margin = new Padding(2, 0, 2, 0);
            lblViewStockTitle.Name = "lblViewStockTitle";
            lblViewStockTitle.Size = new Size(150, 37);
            lblViewStockTitle.TabIndex = 0;
            lblViewStockTitle.Text = "ViewStock";
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCompanyName.Location = new Point(66, 154);
            lblCompanyName.Margin = new Padding(2, 0, 2, 0);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(214, 28);
            lblCompanyName.TabIndex = 1;
            lblCompanyName.Text = "Select Company Name:";
            // 
            // lblModelNumber
            // 
            lblModelNumber.AutoSize = true;
            lblModelNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblModelNumber.Location = new Point(66, 213);
            lblModelNumber.Margin = new Padding(2, 0, 2, 0);
            lblModelNumber.Name = "lblModelNumber";
            lblModelNumber.Size = new Size(207, 28);
            lblModelNumber.TabIndex = 2;
            lblModelNumber.Text = "Select Model Number:";
            // 
            // lblAvailable
            // 
            lblAvailable.AutoSize = true;
            lblAvailable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvailable.Location = new Point(66, 268);
            lblAvailable.Margin = new Padding(2, 0, 2, 0);
            lblAvailable.Name = "lblAvailable";
            lblAvailable.Size = new Size(153, 28);
            lblAvailable.TabIndex = 3;
            lblAvailable.Text = "Select Available:";
            // 
            // cboCompanyName
            // 
            cboCompanyName.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCompanyName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCompanyName.FormattingEnabled = true;
            cboCompanyName.Location = new Point(300, 154);
            cboCompanyName.Margin = new Padding(2);
            cboCompanyName.Name = "cboCompanyName";
            cboCompanyName.Size = new Size(278, 31);
            cboCompanyName.TabIndex = 4;
            cboCompanyName.SelectedIndexChanged += comboCompanyName_SelectedIndexChanged;
            // 
            // cboModelNo
            // 
            cboModelNo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboModelNo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboModelNo.FormattingEnabled = true;
            cboModelNo.Location = new Point(300, 213);
            cboModelNo.Margin = new Padding(2);
            cboModelNo.Name = "cboModelNo";
            cboModelNo.Size = new Size(278, 31);
            cboModelNo.TabIndex = 5;
            cboModelNo.SelectedIndexChanged += comboModelNo_SelectedIndexChanged;
            // 
            // txtAvaib
            // 
            txtAvaib.BackColor = SystemColors.Window;
            txtAvaib.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAvaib.Location = new Point(300, 268);
            txtAvaib.Margin = new Padding(2);
            txtAvaib.Name = "txtAvaib";
            txtAvaib.ReadOnly = true;
            txtAvaib.Size = new Size(278, 30);
            txtAvaib.TabIndex = 6;
            // 
            // ViewStockEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtAvaib);
            Controls.Add(cboModelNo);
            Controls.Add(cboCompanyName);
            Controls.Add(lblAvailable);
            Controls.Add(lblModelNumber);
            Controls.Add(lblCompanyName);
            Controls.Add(lblViewStockTitle);
            Margin = new Padding(2);
            Name = "ViewStockEmployeeForm";
            Size = new Size(706, 600);
            Load += ViewStockEmployeeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblViewStockTitle;
        private Label lblCompanyName;
        private Label lblModelNumber;
        private Label lblAvailable;
        private ComboBox cboCompanyName;
        private ComboBox cboModelNo;
        private TextBox txtAvaib;
    }
}