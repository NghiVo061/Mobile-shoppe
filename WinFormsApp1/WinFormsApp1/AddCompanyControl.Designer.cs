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
            txtCompanyId.Location = new Point(90, 84);
            txtCompanyId.Name = "txtCompanyId";
            txtCompanyId.Size = new Size(91, 20);
            txtCompanyId.TabIndex = 0;
            txtCompanyId.Text = "Company ID";
            txtCompanyId.Click += label1_Click;
            // 
            // txtCompanyName
            // 
            txtCompanyName.AutoSize = true;
            txtCompanyName.Location = new Point(86, 136);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(116, 20);
            txtCompanyName.TabIndex = 1;
            txtCompanyName.Text = "Company Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(208, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(123, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(208, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(128, 27);
            textBox2.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(156, 207);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(83, 30);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddCompanyControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAdd);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtCompanyName);
            Controls.Add(txtCompanyId);
            Name = "AddCompanyControl";
            Size = new Size(514, 396);
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
