using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice3
{
    public partial class Form1 : Form
    {
        int res = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public void NumberClick(object sender, EventArgs e)
        {
            resultTB.Text += ((Button)(sender)).Text;
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
           
        }
    }
}
