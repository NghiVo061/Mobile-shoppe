namespace mobileshope
{
    partial class MainLoginForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lnkAdmin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lnkAdmin
            // 
            this.lnkAdmin.AutoSize = true;
            this.lnkAdmin.Location = new System.Drawing.Point(589, 33);
            this.lnkAdmin.Name = "lnkAdmin";
            this.lnkAdmin.Size = new System.Drawing.Size(0, 16);
            this.lnkAdmin.TabIndex = 0;
            this.lnkAdmin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAdmin_LinkClicked);
            // 
            // MainLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lnkAdmin);
            this.Name = "MainLoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkAdmin;
    }
}

