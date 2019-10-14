using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Broadloom
{
    public partial class FrmBroadloom : Form
    {
        double frmLength;
        double frmWidth;
        public FrmBroadloom()
        {
            InitializeComponent();
        }

        private void FrmBroadloom_Load(object sender, EventArgs e)
        {

        }

        private void LblWidth_Click(object sender, EventArgs e)
        {

        }

        private void TxtLength_TextChanged(object sender, EventArgs e)
        {
            frmLength = Convert.ToDouble(TxtLength.Text);
        }

        private void TxtWidth_TextChanged(object sender, EventArgs e)
        {
            frmWidth = Convert.ToDouble(TxtWidth.Text);
        }

        private void BtnTotal_Click(object sender, EventArgs e)
        {
            double squareMeter = (frmLength * frmWidth);
            double total = squareMeter * 12.0;
            MessageBox.Show("For " +squareMeter.ToString()+"Square Meters"+ "\n" 
                +"The Total is $: " + total.ToString());
        }
    }
}
