namespace WinFormsApp1
{
    partial class SearchCustomerEmployeeForm
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            labelIMEI = new Label();
            txtImei = new TextBox();
            btnSearch = new Button();
            dataGridViewResults = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).BeginInit();
            SuspendLayout();
            // 
            // labelIMEI
            // 
            labelIMEI.AutoSize = true;
            labelIMEI.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelIMEI.Location = new Point(66, 11);
            labelIMEI.Margin = new Padding(2, 0, 2, 0);
            labelIMEI.Name = "labelIMEI";
            labelIMEI.Size = new Size(193, 28);
            labelIMEI.TabIndex = 4;
            labelIMEI.Text = "Enter IMEI Number";
            // 
            // txtImei
            // 
            txtImei.Font = new Font("Segoe UI", 10F);
            txtImei.Location = new Point(266, 13);
            txtImei.Margin = new Padding(2, 2, 2, 2);
            txtImei.Name = "txtImei";
            txtImei.Size = new Size(125, 30);
            txtImei.TabIndex = 1;
            txtImei.TextChanged += txtIMEI_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSearch.Location = new Point(407, 13);
            btnSearch.Margin = new Padding(2, 2, 2, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 28);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridViewResults
            // 
            dataGridViewResults.ColumnHeadersHeight = 29;
            dataGridViewResults.Location = new Point(66, 53);
            dataGridViewResults.Margin = new Padding(2, 2, 2, 2);
            dataGridViewResults.Name = "dataGridViewResults";
            dataGridViewResults.RowHeadersWidth = 51;
            dataGridViewResults.Size = new Size(591, 493);
            dataGridViewResults.TabIndex = 3;
            // 
            // SearchCustomerEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridViewResults);
            Controls.Add(btnSearch);
            Controls.Add(txtImei);
            Controls.Add(labelIMEI);
            Margin = new Padding(2, 2, 2, 2);
            Name = "SearchCustomerEmployeeForm";
            Size = new Size(784, 584);
            Load += SearchCustomerEmployeeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelIMEI;
        private System.Windows.Forms.TextBox txtImei;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridViewResults;
    }
}
