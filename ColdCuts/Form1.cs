using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdCuts
{
    public partial class FrmColdCuts : Form
    {
        double frmTurkey;
        double frmHam;
        double frmTuna;

        public FrmColdCuts()
        {
            InitializeComponent();
        }

        private void TxtTurky_TextChanged(object sender, EventArgs e)
        {
            frmTurkey = Convert.ToDouble(TxtTurky.Text);
        }

        private void TxtHam_TextChanged(object sender, EventArgs e)
        {
            frmHam = Convert.ToDouble(TxtHam.Text);
        }

        private void TxtTuna_TextChanged(object sender, EventArgs e)
        {
            frmTuna = Convert.ToDouble(TxtTuna.Text);
        }

        private void BtnTotal_Click(object sender, EventArgs e)
        {
            double turkey = frmTurkey * 3.25;
            double ham = frmHam * 3.0;
            double tuna = frmTuna * 3.6;
            double total = turkey + ham + tuna;

            MessageBox.Show(
                "Your ordered $" + turkey.ToString() + " worth of turky cold cuts" + "\n" +
                "Your ordered $" + ham.ToString() + " worth of ham cold cuts"+ "\n" +
                "Your ordered $" + tuna.ToString() + " worth of tuna cold cuts" + "\n" +
                "Your Total is: $" + total.ToString()
                );
        }
    }
}
