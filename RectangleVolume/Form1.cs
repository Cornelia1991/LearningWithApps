using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RectangleVolume
{
    public partial class FrmRectangleVolume : Form
    {
        int frmLength;
        int frmWidth;
        int frmHeight;
        public FrmRectangleVolume()
        {
            InitializeComponent();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            frmHeight = Convert.ToInt32(TxtHeight.Text);
        }

        private void LblWidth_Click(object sender, EventArgs e)
        {

        }

        private void FrmRectangleVolume_Load(object sender, EventArgs e)
        {

        }

        private void TxtLength_TextChanged(object sender, EventArgs e)
        {
            frmLength = Convert.ToInt32(TxtLength.Text);
        }

        private void TxtWidth_TextChanged(object sender, EventArgs e)
        {
            frmWidth = Convert.ToInt32(TxtWidth.Text);
        }

        private void BtnGetVolume_Click(object sender, EventArgs e)
        {
            int soultion = frmLength * frmHeight * frmWidth;
            MessageBox.Show("The Volume is: " + soultion.ToString());
        }
    }
}
