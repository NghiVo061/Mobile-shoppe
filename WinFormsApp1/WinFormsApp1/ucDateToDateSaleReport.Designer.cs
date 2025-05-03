namespace WinFormsApp1
{
    partial class ucDateToDateSaleReport
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
            lblStart = new Label();
            dtpStart = new DateTimePicker();
            lblEnd = new Label();
            dtpEnd = new DateTimePicker();
            btnSearch = new Button();
            dgvSales = new DataGridView();
            lblTotal = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            SuspendLayout();
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Location = new Point(30, 20);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(100, 20);
            lblStart.TabIndex = 6;
            lblStart.Text = "Starting Date:";
            // 
            // dtpStart
            // 
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(130, 18);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(120, 27);
            dtpStart.TabIndex = 5;
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Location = new Point(280, 20);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(94, 20);
            lblEnd.TabIndex = 4;
            lblEnd.Text = "Ending Date:";
            // 
            // dtpEnd
            // 
            dtpEnd.Format = DateTimePickerFormat.Short;
            dtpEnd.Location = new Point(380, 18);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(120, 27);
            dtpEnd.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(520, 17);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 28);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += BtnSearch_Click;
            // 
            // dgvSales
            // 
            dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvSales.Location = new Point(30, 60);
            dgvSales.Name = "dgvSales";
            dgvSales.RowHeadersWidth = 51;
            dgvSales.Size = new Size(739, 220);
            dgvSales.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9.5F);
            lblTotal.Location = new Point(30, 295);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(364, 21);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total Sales Amount between [Start] and [End] is = 0";
            // 
            // Column1
            // 
            Column1.HeaderText = "SlsId";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "CompanyName";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "ModelName";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "IMEINo";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Price";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // ucDateToDateSaleReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTotal);
            Controls.Add(dgvSales);
            Controls.Add(btnSearch);
            Controls.Add(dtpEnd);
            Controls.Add(lblEnd);
            Controls.Add(dtpStart);
            Controls.Add(lblStart);
            Name = "ucDateToDateSaleReport";
            Size = new Size(1020, 491);
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Label lblTotal;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}