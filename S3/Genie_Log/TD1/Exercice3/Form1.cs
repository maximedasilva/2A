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
        int left = 0;
        int right = 0;
        int res = 0;
        string operand = "";
        public Form1()
        {
            InitializeComponent();
        }
        public void NumberClick(object sender, EventArgs e)
        {
            resultTB.Text += ((Button)(sender)).Text;
        }

        private void OperandClick(object sender, EventArgs e)
        {
            if (left!=0)
            {
                left = Convert.ToInt32(resultTB.Text);
            }
            else
            {
                right= Convert.ToInt32(resultTB.Text);
            }
           if (operand!="")
            {
                if(operand=="+")
                {
                    left=right + left;
                }
                else
                {
                    left = right - left;
                }
            }

        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
