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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(405, 89);
            label1.Name = "label1";
            label1.Size = new Size(234, 59);
            label1.TabIndex = 0;
            label1.Text = "ViewStock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(129, 204);
            label2.Name = "label2";
            label2.Size = new Size(350, 45);
            label2.TabIndex = 1;
            label2.Text = "Select Company Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(129, 408);
            label3.Name = "label3";
            label3.Size = new Size(248, 45);
            label3.TabIndex = 2;
            label3.Text = "Select Available:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(129, 309);
            label4.Name = "label4";
            label4.Size = new Size(339, 45);
            label4.TabIndex = 3;
            label4.Text = "Select Model Number:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(524, 204);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(396, 36);
            listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(524, 318);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(396, 36);
            listBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(524, 417);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(394, 39);
            textBox1.TabIndex = 6;
            // 
            // ViewStockEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ViewStockEmployeeForm";
            Size = new Size(1147, 960);
            Load += ViewStockEmployeeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox listBox1;
        private ListBox listBox2;
        private TextBox textBox1;
    }
}
