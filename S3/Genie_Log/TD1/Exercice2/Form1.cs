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

            clickBtn.Enabled = false;
            mainTextBox.Enabled = false;
        }
        Timer timer;
        private void beginBtn_Click(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 6000;
            timer.Enabled = true;
            timer.Tick+=new EventHandler(timerEnd);
            timer.Start();
            mainTextBox.Enabled = true;
        }

        private void timerEnd(object sender, EventArgs e)
        {
            timer.Stop();
            MessageBox.Show("Bravo vous avez fait "+ cptLbl.Text);
            cptLbl.Text = "0";
            mainTextBox.Text = "";

            mainTextBox.Enabled = false;
            clickBtn.Enabled = false;
        }

        private void clickBtn_Click(object sender, EventArgs e)
        {
            if(mainTextBox.Text=="bonjour")
            {
               cptLbl.Text =Convert.ToString(Convert.ToInt32(cptLbl.Text) + 1);
            }
        }

        private void mainTextBox_TextChanged(object sender, EventArgs e)
        {
            if(mainTextBox.Text=="bonjour")
            {
                clickBtn.Enabled = true;
            }
        }
    }
}
