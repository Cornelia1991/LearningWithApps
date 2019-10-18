using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheDialogs
{
    public partial class FrmDialogs : Form
    {
        public FrmDialogs()
        {
            InitializeComponent();
        }

        private void BtnMessage_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you understand this?", "Dialog", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                MessageBox.Show("you pressed yes");
            }
            else if (r ==DialogResult.No)
            {
                MessageBox.Show("you pressed no");
            }
        }

        private void BtnCustom_Click(object sender, EventArgs e)
        {
            FrmUser f = new FrmUser();
            DialogResult r = f.ShowDialog();

            if (r == DialogResult.OK)
            {
                MessageBox.Show("Your name is " + f.UserName);
                MessageBox.Show("Your name is " + f.UserAge);
            }
            else
            {
                MessageBox.Show("You Pressed Cancel");
            }
        }
    }
}
