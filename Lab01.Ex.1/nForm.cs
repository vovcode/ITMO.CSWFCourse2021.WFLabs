using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01.Ex._1
{
    public partial class nForm : Form
    {
        private bool nclose = false;
        public new void Close()
        {
            nclose = true;
            base.Close();
        }
        public nForm()
        {
            InitializeComponent();
        }

        private void nForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (nclose)
            {
                return;
            }
            else
            {
                e.Cancel = true;
                Hide();
            };
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
