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
    public partial class Payment_KAMembForm : Form
    {
        public Payment_KAMembForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Payment2_closeButton_Click(object sender, EventArgs e)
        {
            KA_MembBenefitsForm kform = new KA_MembBenefitsForm();
            kform.Show();
            this.Close();
        }

        private void Payment2_closeButton_MouseEnter(object sender, EventArgs e)
        {
            Payment2_closeButton.ForeColor = Color.Gray;
        }

        private void Payment2_closeButton_MouseLeave(object sender, EventArgs e)
        {
            Payment2_closeButton.ForeColor = Color.Black;
        }
    }
}
