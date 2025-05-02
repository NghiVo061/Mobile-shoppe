using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    partial class AddMobileControl
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
            btnInsert = new Button();
            cboCompanyName = new ComboBox();
            cboModelNumber = new ComboBox();
            cboWarrantyDate = new ComboBox();
            txtIMEINumber = new TextBox();
            txtPrice = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 94);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 0;
            label1.Text = "Company Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 169);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 1;
            label2.Text = "Model Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 249);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 2;
            label3.Text = "IMEI Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 320);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 401);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(125, 25);
            label5.TabIndex = 4;
            label5.Text = "Warranty Date";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(188, 470);
            btnInsert.Margin = new Padding(4);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(91, 46);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // cboCompanyName
            // 
            cboCompanyName.FormattingEnabled = true;
            cboCompanyName.Location = new Point(258, 94);
            cboCompanyName.Margin = new Padding(4);
            cboCompanyName.Name = "cboCompanyName";
            cboCompanyName.Size = new Size(139, 33);
            cboCompanyName.TabIndex = 6;
            // 
            // cboModelNumber
            // 
            cboModelNumber.FormattingEnabled = true;
            cboModelNumber.Location = new Point(258, 165);
            cboModelNumber.Margin = new Padding(4);
            cboModelNumber.Name = "cboModelNumber";
            cboModelNumber.Size = new Size(144, 33);
            cboModelNumber.TabIndex = 7;
            cboModelNumber.SelectedIndexChanged += cboModelNumber_SelectedIndexChanged;
            // 
            // cboWarrantyDate
            // 
            cboWarrantyDate.FormattingEnabled = true;
            cboWarrantyDate.Location = new Point(258, 401);
            cboWarrantyDate.Margin = new Padding(4);
            cboWarrantyDate.Name = "cboWarrantyDate";
            cboWarrantyDate.Size = new Size(159, 33);
            cboWarrantyDate.TabIndex = 8;
            // 
            // txtIMEINumber
            // 
            txtIMEINumber.Location = new Point(258, 240);
            txtIMEINumber.Margin = new Padding(4);
            txtIMEINumber.Name = "txtIMEINumber";
            txtIMEINumber.Size = new Size(123, 31);
            txtIMEINumber.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(258, 320);
            txtPrice.Margin = new Padding(4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(135, 31);
            txtPrice.TabIndex = 10;
            // 
            // AddMobileControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtPrice);
            Controls.Add(txtIMEINumber);
            Controls.Add(cboWarrantyDate);
            Controls.Add(cboModelNumber);
            Controls.Add(cboCompanyName);
            Controls.Add(btnInsert);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "AddMobileControl";
            Size = new Size(699, 540);
            Load += AddMobileControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnInsert;
        private ComboBox cboCompanyName;
        private ComboBox cboModelNumber;
        private ComboBox cboWarrantyDate;
        private TextBox txtIMEINumber;
        private TextBox txtPrice;
    }
}
