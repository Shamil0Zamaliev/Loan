using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            double mainsum = Convert.ToDouble(sum.Text);
            double perc = Convert.ToDouble(procent.Text);
            perc = perc/(100*12);



            if (comboprocess.SelectedIndex == 0)
            {
                int months = (Convert.ToInt32(time.Text));
                double X = Math.Round(mainsum * (perc / (1 - (Math.Pow((1 + perc), -months)))));
                monthfee.Text = Convert.ToString(X);
                result.Text = Convert.ToString(X * months);
                difference.Text = Convert.ToString((X * months) - mainsum);
            }
            else if (comboprocess.SelectedIndex == 1)
            {
                int months = (12 * Convert.ToInt32(time.Text));
                double X = Math.Round(mainsum * (perc /( 1 - (Math.Pow((1 + perc), -months)))));
                monthfee.Text = Convert.ToString(X);
                result.Text = Convert.ToString(X*months);
                difference.Text = Convert.ToString((X * months) - mainsum);

            }
        }
    }
}
