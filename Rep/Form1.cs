using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rep
{
    public partial class FrmRep : Form
    {
        public FrmRep()
        {
            InitializeComponent();
        }

        private void BtnRepEx_Click(object sender, EventArgs e)
        {
            // User Controlled Loop
            while (true)
            {
                MessageBox.Show("This is a test");

                string response = Microsoft.VisualBasic.Interaction.InputBox("Do you want to continue y/n", "","");

                if (response == "n")
                    break;
            }
        }

        private void BtnCounter_Click(object sender, EventArgs e)
        {
            //Counter loop
            int counter = 0;

            while (counter <= 10)
            {
                MessageBox.Show("The counter is on number " + counter.ToString());
                counter++;

            }
        }
    }
}
