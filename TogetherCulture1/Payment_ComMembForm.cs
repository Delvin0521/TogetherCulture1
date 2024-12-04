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
    public partial class Payment_ComMembForm : Form
    {
        public Payment_ComMembForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Payment1_closeButton_Click(object sender, EventArgs e)
        {
            ComMembBenefitsForm cbForm = new ComMembBenefitsForm();
            cbForm.Show();
            this.Close();
        }

        private void Payment1_closeButton_MouseEnter(object sender, EventArgs e)
        {
            Payment1_closeButton.ForeColor = Color.Gray;
        }

        private void Payment1_closeButton_MouseLeave(object sender, EventArgs e)
        {
            Payment1_closeButton.ForeColor = Color.Black;
        }
    }
}
