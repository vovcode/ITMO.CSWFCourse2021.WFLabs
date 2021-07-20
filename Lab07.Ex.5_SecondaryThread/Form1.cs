using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07.Ex._5_SecondaryThread
{
    public partial class secThread : Form
    {
        public secThread()
        {
            InitializeComponent();
        }
 
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public string GoButt()
        {
            int maxValue = 0;
            System.Text.StringBuilder
            resultText = new System.Text.StringBuilder();
            if (int.TryParse(MaxValue.Text, out maxValue))
            {
                for (int trial = 2; trial <= maxValue; trial++)
                {
                    bool isPrime = true;
                    for (int divisor = 2; divisor <= Math.Sqrt(trial); divisor++)
                    {
                        if (trial % divisor == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        resText.Text = resultText.AppendFormat("{0} ", trial).ToString();
                    }
                }
            }
            else
            {
                resText.Text = resultText.Append("Unable to parse maximum value.").ToString();
            }
            return resText.Text = resultText.ToString();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            GoButt();
        }
    }
}
