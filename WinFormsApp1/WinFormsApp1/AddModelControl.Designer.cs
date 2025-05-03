namespace WinFormsApp1
{
    partial class AddModelControl
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
            modelId = new Label();
            label2 = new Label();
            modelNumber = new Label();
            txtModelID = new TextBox();
            txtModelNumber = new TextBox();
            cboCompanyName = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // modelId
            // 
            modelId.AutoSize = true;
            modelId.Location = new Point(78, 108);
            modelId.Margin = new Padding(4, 0, 4, 0);
            modelId.Name = "modelId";
            modelId.Size = new Size(86, 25);
            modelId.TabIndex = 0;
            modelId.Text = "Model ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 172);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 1;
            label2.Text = "Company Name";
            // 
            // modelNumber
            // 
            modelNumber.AutoSize = true;
            modelNumber.Location = new Point(78, 241);
            modelNumber.Margin = new Padding(4, 0, 4, 0);
            modelNumber.Name = "modelNumber";
            modelNumber.Size = new Size(115, 25);
            modelNumber.TabIndex = 2;
            modelNumber.Text = "Model Name";
            // 
            // txtModelID
            // 
            txtModelID.Location = new Point(230, 108);
            txtModelID.Margin = new Padding(4);
            txtModelID.Name = "txtModelID";
            txtModelID.ReadOnly = true;
            txtModelID.Size = new Size(135, 31);
            txtModelID.TabIndex = 3;
          
            // 
            // txtModelNumber
            // 
            txtModelNumber.Location = new Point(230, 232);
            txtModelNumber.Margin = new Padding(4);
            txtModelNumber.Name = "txtModelNumber";
            txtModelNumber.Size = new Size(144, 31);
            txtModelNumber.TabIndex = 4;
            // 
            // cboCompanyName
            // 
            cboCompanyName.FormattingEnabled = true;
            cboCompanyName.Location = new Point(230, 172);
            cboCompanyName.Margin = new Padding(4);
            cboCompanyName.Name = "cboCompanyName";
            cboCompanyName.Size = new Size(136, 33);
            cboCompanyName.TabIndex = 5;
            cboCompanyName.SelectedIndexChanged += cboCompanyName_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(179, 332);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(102, 45);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAdd_Click;
            // 
            // AddModelControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(cboCompanyName);
            Controls.Add(txtModelNumber);
            Controls.Add(txtModelID);
            Controls.Add(modelNumber);
            Controls.Add(label2);
            Controls.Add(modelId);
            Margin = new Padding(4);
            Name = "AddModelControl";
            Size = new Size(664, 478);
            Load += AddModelControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label modelId;
        private Label label2;
        private Label modelNumber;
        private TextBox txtModelID;
        private TextBox txtModelNumber;
        private ComboBox cboCompanyName;
        private Button button1;
    }
}
