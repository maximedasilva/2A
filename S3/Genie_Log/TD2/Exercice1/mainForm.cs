using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
namespace Exercice1
{
    public partial class mainForm : Form
    {
        List<Prospect> Prospect;
        public mainForm()
        {
            InitializeComponent();
            Prospect = new List<Domain.Prospect>();
            acceptBtn.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            acceptBtn.Visible = true;
            mailTB.Text = "";
            NomTB.Text = "";
            PrenomTB.Text = "";
            contactDTP.Value = DateTime.Today;
            notesTB.Text = "";
            PrenomTB.Enabled = true;
            NomTB.Enabled = true;
            mailTB.Enabled = true;
            notesTB.Enabled = true;
            contactDTP.Enabled = true;
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            Prospect pt = new Prospect(NomTB.Text, PrenomTB.Text, mailTB.Text, contactDTP.Value,notesTB.Text);
            Prospect.Add(pt);
            prospectLB.Items.Add(pt.ToString());
            acceptBtn.Visible = false;
            mailTB.Text = "";
            NomTB.Text = "";
            PrenomTB.Text = "";
            contactDTP.Value = DateTime.Today;
            notesTB.Text = "";
            PrenomTB.Enabled = false;
            NomTB.Enabled = false;
            mailTB.Enabled = false;
            notesTB.Enabled = false;
            contactDTP.Enabled = false;
        }

        private void prospectLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Prospect p = Prospect.Find((x => x.ToString() == prospectLB.GetItemText(prospectLB.SelectedItem)));
            NomTB.Text = p.lastName;
            PrenomTB.Text = p.firstName;
            mailTB.Text = p.email;
            contactDTP.Value = p.lastContact;
            notesTB.Text = p.notes;

            PrenomTB.Enabled = false;
            NomTB.Enabled = false;
            mailTB.Enabled = false;
            notesTB.Enabled = false;
            contactDTP.Enabled = false;
        }
    }
}
