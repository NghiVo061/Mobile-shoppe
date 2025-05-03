namespace WinFormsApp1
{
    partial class AddCompanyControl
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
            txtCompanyId = new Label();
            txtCompanyName = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // txtCompanyId
            // 
            txtCompanyId.AutoSize = true;
            txtCompanyId.Location = new Point(112, 105);
            txtCompanyId.Margin = new Padding(4, 0, 4, 0);
            txtCompanyId.Name = "txtCompanyId";
            txtCompanyId.Size = new Size(112, 25);
            txtCompanyId.TabIndex = 0;
            txtCompanyId.Text = "Company ID";
            txtCompanyId.Click += label1_Click;
            // 
            // txtCompanyName
            // 
            txtCompanyName.AutoSize = true;
            txtCompanyName.Location = new Point(108, 170);
            txtCompanyName.Margin = new Padding(4, 0, 4, 0);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(141, 25);
            txtCompanyName.TabIndex = 1;
            txtCompanyName.Text = "Company Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(260, 105);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(153, 31);
            textBox1.TabIndex = 2;

       
            // 
            // textBox2
            // 
            textBox2.Location = new Point(260, 166);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(159, 31);
            textBox2.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(195, 259);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 38);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddCompanyControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAdd);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtCompanyName);
            Controls.Add(txtCompanyId);
            Margin = new Padding(4);
            Name = "AddCompanyControl";
            Size = new Size(642, 495);
            Load += AddCompanyControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtCompanyId;
        private Label txtCompanyName;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnAdd;
    }
}
