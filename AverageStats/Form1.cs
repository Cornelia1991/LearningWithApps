using System;
using System.Windows.Forms;

namespace AverageStats
{
    public partial class FrmAverageStats : Form
    {
        public FrmAverageStats()
        {
            InitializeComponent();
        }

        private void BtnGetInfo_Click(object sender, EventArgs e)
        {
            double age;
            int count = 0;
            double height;
            double totalAge = 0;
            double totalHeight = 0;
            double averageAge = 0;
            double averageHeight = 0;
            string response = "";

            while (true)
            {
                do
                {
                    response = Microsoft.VisualBasic.Interaction.InputBox("do you wish to continue y/n", "Averages", "", 200, 200);
                }
                while (response != "y" && response != "n");

                if (response == "n")
                    break;

                age = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Enter an age between 13 and 18 ", "Averages", "", 200, 200));
                if (age < 13 || age > 18)
                {
                    MessageBox.Show("Invalid Age");
                }
                else
                {
                    count++;
                    totalAge += age;
                }

                height = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Enter height in cenemeters ", "Averages", "", 200, 200));
                if (height < 1)
                { 
                    MessageBox.Show("Invalid Age");
                }
                else
                {
                    totalHeight += height;
                }

            }

            if (count != 0)
            {
                averageAge = totalAge / count;
                averageHeight = totalHeight / count;
                MessageBox.Show("The average age is " + averageAge.ToString("n2") 
                    + "\n" + "The average cenemeters is " + averageHeight.ToString("n2"));
            }
            else
            {
                MessageBox.Show("No marks entered");
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmWhileTrue_Load(object sender, EventArgs e)
        {

        }

    }
    
}
