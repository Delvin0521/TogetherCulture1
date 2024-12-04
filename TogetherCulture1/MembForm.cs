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
    public partial class MembForm : Form
    {
        public MembForm()
        {
            InitializeComponent();
        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void logoutMembPageButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to Logout?","Logout Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

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

        private void memb1_GotoButton_Click(object sender, EventArgs e)
        {
            ComMembBenefitsForm benefits1Form = new ComMembBenefitsForm();
            benefits1Form.Show();   
            this.Close();
        }

        private void memb2_GotoButton_Click(object sender, EventArgs e)
        {
            KA_MembBenefitsForm benefits2Form = new KA_MembBenefitsForm();
            benefits2Form.Show();
            this.Close();
        }

        private void memb3_GotoButton_Click(object sender, EventArgs e)
        {
            WorkMembBenefitsForm benefits3Form = new WorkMembBenefitsForm();
            benefits3Form.Show();
            this.Close();
        }

        private void GotoEvents_membPage_Click(object sender, EventArgs e)
        {

        }

        private void gotoHome_membPage_Click(object sender, EventArgs e)
        {
            HomepageForm hpForm = new HomepageForm();
            hpForm.Show();
            this.Close();
        }

        private void gotoHome_membPage_MouseEnter(object sender, EventArgs e)
        {
            gotoHome_membPage.ForeColor = Color.Gray;
        }

        private void gotoHome_membPage_MouseLeave(object sender, EventArgs e)
        {
            gotoHome_membPage.ForeColor = Color.Black;
        }

        private void GotoEvents_membPage_MouseEnter(object sender, EventArgs e)
        {
           GotoEvents_membPage.ForeColor = Color.Gray;
        }

        private void GotoEvents_membPage_MouseLeave(object sender, EventArgs e)
        {
           GotoEvents_membPage.ForeColor = Color.Black;
        }

        private void GotoDash_membPage_MouseEnter(object sender, EventArgs e)
        {
            GotoDash_membPage.ForeColor = Color.Gray;
        }

        private void GotoDash_membPage_MouseLeave(object sender, EventArgs e)
        {
            GotoDash_membPage.ForeColor = Color.Black;
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void membpage_closeButton_Click(object sender, EventArgs e)
        {

        }

        private void membpage_closeButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void membpage_closeButton_MouseEnter(object sender, EventArgs e)
        {
            membpage_closeButton.ForeColor = Color.Gray;
        }

        private void membpage_closeButton_MouseLeave(object sender, EventArgs e)
        {
            membpage_closeButton.ForeColor = Color.Black;
        }
    }
}
