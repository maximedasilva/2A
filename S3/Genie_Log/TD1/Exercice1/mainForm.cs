using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice1
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            domainCB.Items.Add("Réseau");
            domainCB.Items.Add("Bureautique");
            domainCB.Items.Add("Développement");
            formationLB.Visible = false;
            OptionCLB.Visible = false;
            lieuGP.Visible = false;
            radioButton1.Checked = true;
           
        }

        private void domainCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rep = domainCB.SelectedText;
            if(formationLB.Visible==false && domainCB.SelectedIndex!=-1)
            {
                formationLB.Visible = true;
            }
            OptionCLB.Visible = false;
            lieuGP.Visible = false;
            OptionCLB.SelectedIndex = -1;
            formationLB.Items.Clear();
            if ( domainCB.Text=="Réseau")
            {
               
                formationLB.Items.Add("Cisco CCNA");
                formationLB.Items.Add("Ethernet");
                formationLB.Items.Add("wifi");

            }
             else if(domainCB.Text=="Bureautique")
            {
               
                formationLB.Items.Add("Microsoft Office");
                formationLB.Items.Add("LibreOffice");
            }
             else if (domainCB.Text == "Développement")
            {
                formationLB.Items.Add("Java");
                formationLB.Items.Add("PHP");
                formationLB.Items.Add("C#");
            }
        }

        private void formationLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!OptionCLB.Visible)
            {
                OptionCLB.Visible = true;
                lieuGP.Visible = true;
            }
            OptionCLB.Items.Clear();
            if(domainCB.Text=="Réseau")
            {
                switch (formationLB.Text)
                {
                   case "Cisco CCNA":
                        OptionCLB.Items.Add("Aide en ligne");
                        OptionCLB.Items.Add("passage de tests");
                        break;
                    default:
                        OptionCLB.Items.Add("Etudes de normes futures");
                        OptionCLB.Items.Add("Matériel Fourni");
                        break;
                }
            }
            else if(domainCB.Text=="Bureautique")
            {
                switch(formationLB.Text)
                {
                    case "Microsoft Office":
                        OptionCLB.Items.Add("Support Papier");
                        OptionCLB.Items.Add("Examen Final");
                        OptionCLB.Items.Add("Licence Logiciel");
                        break;
                    case "LibreOffice":
                        OptionCLB.Items.Add("Support Papier");
                        OptionCLB.Items.Add("Examen Final");
                        OptionCLB.Items.Add("Projet d'exemple");
                        break;
                }
            }
            else 
            {
                switch(formationLB.Text)
                {
                    case "Java":
                        OptionCLB.Items.Add("formateurs certifiés");
                        OptionCLB.Items.Add("Supports DVD-Rom");
                        break;
                    case "PHP":
                        OptionCLB.Items.Add("Php Procédural");
                        OptionCLB.Items.Add("Php Objet");
                        break;
                    case "C#":
                        OptionCLB.Items.Add("Formateurs certifiés");
                        OptionCLB.Items.Add("support DVD-Rom");
                        break;

                }

            }
        }

        private void ValidateBtn_Click(object sender, EventArgs e)
        {
            if (domainCB.SelectedIndex == -1 || formationLB.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez choisir une formation et/ ou un domaine");
            }
            else {
                string lieu;
                if (radioButton1.Checked)
                {
                    lieu = radioButton1.Text;
                }
                else
                    lieu = radioButton2.Text;
                string options = "";
                foreach (var it in OptionCLB.CheckedItems)
                {
                    options += it + " ";
                }
                if (options=="")
                {
                    options = "Sans option";
                }
                string rep = String.Format("Vous avez choisi la formation {0} du domaine {1} \n Lieu de formation: {2} \n Options de la formation: {3} \n merci de votre choix et bonne formation!", formationLB.Text, domainCB.Text, lieu, options);
                MessageBox.Show(rep);
            }
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            formationLB.SelectedIndex = -1;
            domainCB.SelectedIndex = -1;
            OptionCLB.SelectedIndex = -1;
        }
    }
}
