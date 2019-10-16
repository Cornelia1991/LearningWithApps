using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasCompany
{
    public partial class FrmGasCompany : Form
    {
        double ccfUsed;
        double kwhUsed;
        public FrmGasCompany()
        {
            InitializeComponent();
        }

        private void FrmGasCompany_Load(object sender, EventArgs e)
        {

        }

        private void TxtCcfAmount_TextChanged(object sender, EventArgs e)
        {
            ccfUsed = double.Parse(TxtCcfAmount.Text);
        }

        private void BtnGetBill_Click(object sender, EventArgs e)
        {
            double totalCff = 0;

            if (ccfUsed <= 8)
            {
                totalCff = ccfUsed * .5;
            }
            else if (ccfUsed > 8)
            {
                totalCff = (8 * .5) + ((ccfUsed - 8) *.30);
            }

            MessageBox.Show( "The total is " + totalCff.ToString("c"));
            
        }

        private void TxtKwh_TextChanged(object sender, EventArgs e)
        {
            kwhUsed = Double.Parse(TxtKwh.Text);
        }

        private void BtnKwh_Click(object sender, EventArgs e)
        {
            double totalKwh = 0;

            if (kwhUsed <= 12)
            {
                totalKwh = 2.50;
            }
            else if (kwhUsed > 12 && kwhUsed <= 90)
            {
                totalKwh = (2.50) + ((kwhUsed - 12) * 0.08);
            }
            else if (kwhUsed > 90)
            {
                totalKwh = (8.74) + ((kwhUsed - 90) * 0.06);
            }

            MessageBox.Show("The Total is " + totalKwh.ToString("c"));
        }
    }
}
