namespace WinFormsApp1
{
    partial class IntroduceForm
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
            lblSubject = new Label();
            lblTeacher = new Label();
            lblProject = new Label();
            lblMembers = new Label();
            lblMember1 = new Label();
            lblMember2 = new Label();
            btnStart = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblSubject.Location = new Point(263, 40);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(777, 59);
            lblSubject.TabIndex = 0;
            lblSubject.Text = "Xây dựng hệ thống thông tin quản lý";
            // 
            // lblTeacher
            // 
            lblTeacher.AutoSize = true;
            lblTeacher.Font = new Font("Segoe UI", 14F);
            lblTeacher.Location = new Point(376, 198);
            lblTeacher.Name = "lblTeacher";
            lblTeacher.Size = new Size(527, 51);
            lblTeacher.TabIndex = 1;
            lblTeacher.Text = "Giáo viên: Nguyễn Thanh Bình";
            // 
            // lblProject
            // 
            lblProject.AutoSize = true;
            lblProject.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProject.Location = new Point(417, 110);
            lblProject.Name = "lblProject";
            lblProject.Size = new Size(465, 59);
            lblProject.TabIndex = 2;
            lblProject.Text = "Dự án: MobileShoppe";
            // 
            // lblMembers
            // 
            lblMembers.AutoSize = true;
            lblMembers.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblMembers.Location = new Point(28, 336);
            lblMembers.Name = "lblMembers";
            lblMembers.Size = new Size(408, 51);
            lblMembers.TabIndex = 3;
            lblMembers.Text = "Thành viên thực hiện:";
            // 
            // lblMember1
            // 
            lblMember1.AutoSize = true;
            lblMember1.Font = new Font("Segoe UI", 12F);
            lblMember1.Location = new Point(77, 404);
            lblMember1.Name = "lblMember1";
            lblMember1.Size = new Size(496, 45);
            lblMember1.TabIndex = 4;
            lblMember1.Text = "1. Trần Thành Đông - 2251120061";
            // 
            // lblMember2
            // 
            lblMember2.AutoSize = true;
            lblMember2.Font = new Font("Segoe UI", 12F);
            lblMember2.Location = new Point(77, 465);
            lblMember2.Name = "lblMember2";
            lblMember2.Size = new Size(476, 45);
            lblMember2.TabIndex = 5;
            lblMember2.Text = "2. Lưu Trường Văn - 2251120015";
            // 
            // btnStart
            // 
            btnStart.BackColor = SystemColors.ActiveCaptionText;
            btnStart.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnStart.ForeColor = SystemColors.ControlLightLight;
            btnStart.Location = new Point(799, 418);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(180, 92);
            btnStart.TabIndex = 6;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1213, 732);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblSubject);
            panel2.Controls.Add(btnStart);
            panel2.Controls.Add(lblTeacher);
            panel2.Controls.Add(lblMember2);
            panel2.Controls.Add(lblProject);
            panel2.Controls.Add(lblMember1);
            panel2.Controls.Add(lblMembers);
            panel2.Location = new Point(57, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(1123, 643);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            pictureBox1.Image = Image.FromFile("Resources/LogoUTH.png");
            // 
            pictureBox1.Location = new Point(38, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 186);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // IntroduceForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 735);
            Controls.Add(panel1);
            Name = "IntroduceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giới thiệu dự án";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblSubject;
        private Label lblTeacher;
        private Label lblProject;
        private Label lblMembers;
        private Label lblMember1;
        private Label lblMember2;
        private Button btnStart;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}