﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TogetherCulture1
{
    public partial class HomepageForm : Form
    {
        public HomepageForm()
        {
            InitializeComponent();
        }

        private void gotoMembHomepage_MouseEnter(object sender, EventArgs e)
        {
            gotoMembHomepage.ForeColor = Color.Gray;
        }

        private void gotoMembHomepage_MouseLeave(object sender, EventArgs e)
        {
            gotoMembHomepage.ForeColor = Color.Black;
        }

        private void gotoDashHomePage_MouseEnter(object sender, EventArgs e)
        {
            gotoDashHomePage.ForeColor = Color.Gray;
        }

        private void gotoDashHomePage_MouseLeave(object sender, EventArgs e)
        {
            gotoDashHomePage.ForeColor= Color.Black;
        }

        private void gotoMembHomepage_Click(object sender, EventArgs e)
        {
            MembForm mform = new MembForm();
            mform.Show();
            this.Hide();
        }
    }
}
