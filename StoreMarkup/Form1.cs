using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreMarkup
{
    public partial class FrmMarkup : Form
    {
        double sellPrice;
        double cost;
        public FrmMarkup()
        {
            InitializeComponent();
        }

        private void LblCost_Click(object sender, EventArgs e)
        {

        }

        private void TxtCost_TextChanged(object sender, EventArgs e)
        {
            cost = Convert.ToDouble(TxtCost.Text);
        }

        private void TxtSellPrice_TextChanged(object sender, EventArgs e)
        {
            sellPrice = Convert.ToDouble(TxtSellPrice.Text);
        }

        private void BtnMarkup_Click(object sender, EventArgs e)
        {
            double markup = ((sellPrice - cost) / (cost)) * 100;
            MessageBox.Show("The markup is " + Math.Round(markup, 2) + "%");
        }
    }
}
