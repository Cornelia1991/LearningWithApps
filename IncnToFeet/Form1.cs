using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncnToFeet
{
    public partial class FrmFeetInch : Form
    {
        public FrmFeetInch()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmFeetInch_Load(object sender, EventArgs e)
        {

        }

        private void BtnConvertInches_Click(object sender, EventArgs e)
        {
            int inches;
            int feet;
            int remainingInches;

            inches = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Enter Inches", "",""));

            feet = inches / 12;
            remainingInches = inches % 12;

            MessageBox.Show("You Entered " +inches.ToString()+ "\n" + " That is " +feet.ToString()+ " Feet and " +remainingInches.ToString()+ " Inches");
        }
    }
}
