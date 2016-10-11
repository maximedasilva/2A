using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Timer timer;
        private void beginBtn_Click(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 6000;
            timer.Enabled = true;
            timer.Tick+=new EventHandler(timerEnd);
            timer.Start();
        }

        private void timerEnd(object sender, EventArgs e)
        {
            MessageBox.Show("Bravo vous avez fait "+ cptLbl.Text);
            cptLbl.Text = "0";
            mainTextBox.Text = "";
            timer.Stop();
            
        }

        private void clickBtn_Click(object sender, EventArgs e)
        {
            if(mainTextBox.Text=="bonjour")
            {
               cptLbl.Text =Convert.ToString(Convert.ToInt32(cptLbl.Text) + 1);
            }
        }
    }
}
