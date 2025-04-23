namespace WinFormsApp1
{
    partial class UpdateStockControl
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
            txtTransID = new TextBox();
            txtQuantity = new TextBox();
            txtAmount = new TextBox();
            cboCompanyName = new ComboBox();
            cboModelNumber = new ComboBox();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 72);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Trans ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 132);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 1;
            label2.Text = "Company Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 189);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 2;
            label3.Text = "Model Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 241);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 3;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 295);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 4;
            label5.Text = "Amount";
            // 
            // txtTransID
            // 
            txtTransID.Location = new Point(183, 72);
            txtTransID.Name = "txtTransID";
            txtTransID.Size = new Size(125, 27);
            txtTransID.TabIndex = 5;
            
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(183, 241);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 6;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(183, 292);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(125, 27);
            txtAmount.TabIndex = 7;
            // 
            // cboCompanyName
            // 
            cboCompanyName.FormattingEnabled = true;
            cboCompanyName.Location = new Point(183, 124);
            cboCompanyName.Name = "cboCompanyName";
            cboCompanyName.Size = new Size(151, 28);
            cboCompanyName.TabIndex = 8;
            // 
            // cboModelNumber
            // 
            cboModelNumber.FormattingEnabled = true;
            cboModelNumber.Location = new Point(183, 181);
            cboModelNumber.Name = "cboModelNumber";
            cboModelNumber.Size = new Size(151, 28);
            cboModelNumber.TabIndex = 9;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(113, 346);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // UpdateStockControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnUpdate);
            Controls.Add(cboModelNumber);
            Controls.Add(cboCompanyName);
            Controls.Add(txtAmount);
            Controls.Add(txtQuantity);
            Controls.Add(txtTransID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateStockControl";
            Size = new Size(510, 416);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTransID;
        private TextBox txtQuantity;
        private TextBox txtAmount;
        private ComboBox cboCompanyName;
        private ComboBox cboModelNumber;
        private Button btnUpdate;
    }
}
