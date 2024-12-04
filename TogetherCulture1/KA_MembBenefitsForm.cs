using System;
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
    public partial class KA_MembBenefitsForm : Form
    {
        public KA_MembBenefitsForm()
        {
            InitializeComponent();
        }

        private void GotoHome_memb2Page_Click(object sender, EventArgs e)
        {
            HomepageForm hpform = new HomepageForm();
            hpform.Show();
            this.Close();
        }

        private void Gotomemb_memb2Page_Click(object sender, EventArgs e)
        {
            MembForm mform = new MembForm();
            mform.Show();
            this.Close();
        }

        private void logoutKAPageButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to Logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                LoginForm lForm = new LoginForm();
                lForm.Show();
                this.Hide(); // Hide the current form
            }
            else
            {

            }
        }

        private void memb2page_closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sub_KAPageButton_Click(object sender, EventArgs e)
        {
            Payment_KAMembForm p2Form = new Payment_KAMembForm();
            p2Form.Show();
            this.Close();
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void GotoHome_memb2Page_MouseEnter(object sender, EventArgs e)
        {
            GotoHome_memb2Page.ForeColor = Color.Gray;
        }

        private void GotoHome_memb2Page_MouseLeave(object sender, EventArgs e)
        {
            GotoHome_memb2Page.ForeColor = Color.Black;
        }

        private void Gotomemb_memb2Page_MouseEnter(object sender, EventArgs e)
        {
            Gotomemb_memb2Page.ForeColor = Color.Gray;
        }

        private void Gotomemb_memb2Page_MouseLeave(object sender, EventArgs e)
        {
            Gotomemb_memb2Page.ForeColor = Color.Black;
        }

        private void GotoEvents_memb2Page_MouseEnter(object sender, EventArgs e)
        {
            GotoEvents_memb2Page.ForeColor = Color.Gray;
        }

        private void GotoEvents_memb2Page_MouseLeave(object sender, EventArgs e)
        {
            GotoEvents_memb2Page.ForeColor = Color.Black;
        }

        private void GotoDash_memb2Page_MouseEnter(object sender, EventArgs e)
        {
            GotoDash_memb2Page.ForeColor = Color.Gray;
        }

        private void GotoDash_memb2Page_MouseLeave(object sender, EventArgs e)
        {
            GotoDash_memb2Page.ForeColor = Color.Black;
        }

        private void memb2page_closeButton_MouseLeave(object sender, EventArgs e)
        {
            memb2page_closeButton.ForeColor = Color.Black;
        }

        private void memb2page_closeButton_MouseEnter(object sender, EventArgs e)
        {
            memb2page_closeButton.ForeColor = Color.Gray;
        }
    }
}
