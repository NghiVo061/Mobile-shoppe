using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Employee : Form
    {
        private Panel confirmationPanel;

        public Employee()
        {
            InitializeComponent();
            InitializeConfirmationPanel();
        }

        private void InitializeConfirmationPanel()
        {
            confirmationPanel = new Panel
            {
                Location = new Point(50, 50),
                Size = new Size(700, 300),
                BackColor = Color.White,
                Visible = false,
                BorderStyle = BorderStyle.FixedSingle
            };

            var lblTitle = new Label
            {
                Text = "Confirmation",
                Font = new Font("Arial", 16, FontStyle.Bold),
                Location = new Point(20, 20),
                AutoSize = true
            };
            confirmationPanel.Controls.Add(lblTitle);

            // Create labels for confirmation data
            var lblConfirmCustomerName = new Label { Location = new Point(50, 60), AutoSize = true };
            var lblConfirmMobileNumber = new Label { Location = new Point(50, 90), AutoSize = true };
            var lblConfirmAddress = new Label { Location = new Point(50, 120), AutoSize = true };
            var lblConfirmEmail = new Label { Location = new Point(50, 150), AutoSize = true };
            var lblConfirmCompanyName = new Label { Location = new Point(50, 180), AutoSize = true };
            var lblConfirmModelNumber = new Label { Location = new Point(50, 210), AutoSize = true };
            var lblConfirmImeiNumber = new Label { Location = new Point(50, 240), AutoSize = true };
            var lblConfirmPrice = new Label { Location = new Point(50, 270), AutoSize = true };

            confirmationPanel.Controls.Add(lblConfirmCustomerName);
            confirmationPanel.Controls.Add(lblConfirmMobileNumber);
            confirmationPanel.Controls.Add(lblConfirmAddress);
            confirmationPanel.Controls.Add(lblConfirmEmail);
            confirmationPanel.Controls.Add(lblConfirmCompanyName);
            confirmationPanel.Controls.Add(lblConfirmModelNumber);
            confirmationPanel.Controls.Add(lblConfirmImeiNumber);
            confirmationPanel.Controls.Add(lblConfirmPrice);

            // Add buttons
            var btnOK = new Button
            {
                Text = "OK",
                Location = new Point(600, 220),
                Size = new Size(80, 30)
            };
            btnOK.Click += (s, e) => {
                confirmationPanel.Visible = false;
                SetInputControlsVisible(true);
                ClearForm();
            };

            confirmationPanel.Controls.Add(btnOK);
            this.Controls.Add(confirmationPanel);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Update confirmation panel labels
            var labels = confirmationPanel.Controls.OfType<Label>().ToList();
            labels[1].Text = $"Customer Name: {txtCustomerName.Text}";
            labels[2].Text = $"Mobile Number: {txtMobileNumber.Text}";
            labels[3].Text = $"Address: {txtAddress.Text}";
            labels[4].Text = $"Email ID: {txtEmail.Text}";
            labels[5].Text = $"Company Name: {txtCompanyName.Text}";
            labels[6].Text = $"Model Number: {txtModelNumber.Text}";
            labels[7].Text = $"IMEI Number: {txtImeiNumber.Text}";
            labels[8].Text = $"Price/Place: {txtPrice.Text}";

            SetInputControlsVisible(false);
            confirmationPanel.Visible = true;
        }

        private void SetInputControlsVisible(bool visible)
        {
            foreach (Control control in this.Controls)
            {
                if (control != confirmationPanel)
                {
                    control.Visible = visible;
                }
            }
        }

        private void ClearForm()
        {
            txtCustomerName.Text = "";
            txtMobileNumber.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtCompanyName.Text = "";
            txtModelNumber.Text = "";
            txtImeiNumber.Text = "";
            txtPrice.Text = "";
        }
    }
}