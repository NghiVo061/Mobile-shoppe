
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class IntroduceForm : Form
    {
        public IntroduceForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Create an instance of the LoginForm
            LoginForm loginForm = new LoginForm();

            // Show the LoginForm
            loginForm.Show();

            // Hide or close the current form
            this.Hide(); // Use this.Close() if you want to completely close it
        }

        private void lblSubject_Click(object sender, EventArgs e)
        {

        }

        private void lblTeacher_Click(object sender, EventArgs e)
        {

        }

        private void lblMember1_Click(object sender, EventArgs e)
        {

        }
    }

}