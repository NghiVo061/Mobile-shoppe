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
            labelIMEI = new System.Windows.Forms.Label();
            txtIMEI = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            dataGridViewResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(dataGridViewResults)).BeginInit();
            SuspendLayout();

            // labelIMEI
            labelIMEI.AutoSize = true;
            labelIMEI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            labelIMEI.Location = new System.Drawing.Point(82, 14);
            labelIMEI.Name = "labelIMEI";
            labelIMEI.Size = new System.Drawing.Size(234, 32);
            labelIMEI.Text = "Enter IMEI Number";

            // txtIMEI
            txtIMEI.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtIMEI.Location = new System.Drawing.Point(332, 16);
            txtIMEI.Name = "txtIMEI";
            txtIMEI.Size = new System.Drawing.Size(155, 34);
            txtIMEI.TabIndex = 1;
            txtIMEI.TextChanged += txtIMEI_TextChanged;

            // btnSearch
            btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnSearch.Location = new System.Drawing.Point(509, 16);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(117, 35);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;

            // dataGridViewResults
            dataGridViewResults.Location = new System.Drawing.Point(82, 66);
            dataGridViewResults.Name = "dataGridViewResults";
            dataGridViewResults.Size = new System.Drawing.Size(739, 616);
            dataGridViewResults.TabIndex = 3;
            dataGridViewResults.AutoGenerateColumns = true;

            // SearchCustomerEmployeeForm
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(dataGridViewResults);
            Controls.Add(btnSearch);
            Controls.Add(txtIMEI);
            Controls.Add(labelIMEI);
            Name = "SearchCustomerEmployeeForm";
            Size = new System.Drawing.Size(980, 730);
            Load += SearchCustomerEmployeeForm_Load;
            ((System.ComponentModel.ISupportInitialize)(dataGridViewResults)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelIMEI;
        private System.Windows.Forms.TextBox txtIMEI;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridViewResults;
    }
}
