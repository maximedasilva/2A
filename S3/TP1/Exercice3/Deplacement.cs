using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    class Deplacement
    {
        private static int UniqueDeplacement = 0;
        public  int nbDeplacement
        {
            get; private set;
        }
        Date debut;
        Date fin;
        string destination;
        string raison;
        public Deplacement(Date _debut,Date _fin,string _destination,string _raison)
        {
            nbDeplacement = UniqueDeplacement++;
            debut = _debut;
            fin = _fin;
            destination = _destination;
            raison = _raison;

        }
        public void afficherCaractéristique()
        {
            Console.WriteLine("Deplacement N°{0}, du {1}/{2}/{3} au {4}/{5}/{6} a {7} pour {8} durant {9} jours", nbDeplacement, debut.jour, debut.mois, debut.annee, fin.jour, fin.mois, fin.annee, destination, raison,calculeDuree());
        }
        public int calculeDuree()
        {
            return fin.calculeDuree(debut);
        }

    }
}
