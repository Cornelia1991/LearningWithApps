using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGrades
{
    public partial class FrmTestGrades : Form
    {
        double test1, test2, test3, test4;

        public FrmTestGrades()
        {
            InitializeComponent();
        }

        private void TxtTestOne_TextChanged(object sender, EventArgs e)
        {
            test1 = double.Parse(TxtTestOne.Text);
        }

        private void TxtTestTwo_TextChanged(object sender, EventArgs e)
        {
            test2 = double.Parse(TxtTestTwo.Text);
        }

        private void TxtTestThree_TextChanged(object sender, EventArgs e)
        {
            test3 = double.Parse(TxtTestThree.Text);

        }

        private void TxtTestFour_TextChanged(object sender, EventArgs e)
        {
            test4 = double.Parse(TxtTestFour.Text);
        }

        private void TxtResults_TextChanged(object sender, EventArgs e)
        {
            TxtResults.Visible = false;
        }

        private void LblFormTitle_Click(object sender, EventArgs e)
        {

        }

        private void LblTestFour_Click(object sender, EventArgs e)
        {

        }

        private void FrmTestGrades_Load(object sender, EventArgs e)
        {

        }

        private void BtnGetResult_Click(object sender, EventArgs e)
        {
            
            double results = (test1 + test2 + test3 + test4)/4;
            if (results >= 60)
            {
                TxtResults.Text = "You Passed! \n Your grade is " + results.ToString("n2");
            }
            else
            {
                TxtResults.Text = "You Failed. \n Your grade is " + results.ToString("n2");

            }
            TxtResults.Visible = true;
        }
    }
}
