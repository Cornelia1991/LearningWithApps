using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Averages
{
    public partial class FrmAverages : Form
    {
        public FrmAverages()
        {
            InitializeComponent();
        }

        private void BtnAverages_Click(object sender, EventArgs e)
        {
            int mark1;
            int mark2;
            int mark3;
            double average = 0;

            mark1 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Please enter a mark", "Average", "50" ));
            mark2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Please enter a mark", "Average", "50"));
            mark3 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Please enter a mark", "Average", "50"));

            average = (double)(mark1 + mark2 + mark3) / 3;
            MessageBox.Show("The average is " + average.ToString());
        }
    }
}
