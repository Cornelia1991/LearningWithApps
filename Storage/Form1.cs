using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage
{
    public partial class FrmStorage : Form
    {
        public FrmStorage()
        {
            InitializeComponent();
        }

        //declaration of variables section
        int age;
        string yourName;
        double pay;

        private void BtnGo_Click(object sender, EventArgs e)
        {

            // assignment statements
            age = 28;
            yourName = "Cornelia";
            pay = 210.50;

            //display the results... output
            MessageBox.Show("Your age is " + age.ToString());
            MessageBox.Show("Your name is " + yourName);
            MessageBox.Show("Your pay is " + pay.ToString());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your name is " + yourName);
        }
    }
}
