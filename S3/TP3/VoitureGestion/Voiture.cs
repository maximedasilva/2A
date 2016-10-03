using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VoitureGestion
{
    public class Voiture
    {
        private int numVoiture;
        public double prixVoyage { get; set; }
        public Voiture(int _nbChevaux, int _numVoiture)
        {
            NbChevaux = _nbChevaux;
            numVoiture = _numVoiture;
            Reservoir = new Reservoir(NbChevaux);
            Compteur = new Compteur();
        }

        public Reservoir Reservoir
        {
            get; 
        }

        public Compteur Compteur
        {
            get; 
        }

   
        public int NbChevaux
        {
            get; set;
        }

        public void rouler(double nbKilometres, double _vitesse)
        {

            Compteur.Vitesse = _vitesse;
            while (nbKilometres > 0)
            {
                if(Reservoir.distanceMaxi(Conso()) <nbKilometres)
                {
                    nbKilometres -= Reservoir.distanceMaxi(Conso());
                    Console.WriteLine(Reservoir.distanceMaxi(Conso()));
                    Depanner();
                }
               
                    if(nbKilometres>100 && Conso()>Reservoir.QuantiteActuelle)
                    {
                        Reservoir.QuantiteActuelle -= Conso();
                    }
                    else
                    {
                        Reservoir.QuantiteActuelle -= Conso() / 100;
                    nbKilometres--;
                    }
                
            }
            FaireLePlein();
        }

        public float Conso()
        {
            if(Compteur.Vitesse<80)
            {
                return 6 + ((float)0.0015 * (float)(NbChevaux - 4));
            }

            else if (Compteur.Vitesse > 80 && Compteur.Vitesse < 100)
            {
                return 7 + ((float)0.0015 * (float)(NbChevaux - 4));
            }

            else if (Compteur.Vitesse > 100 && Compteur.Vitesse < 120)
            {
                return 8 + ((float)0.0015 * (float)(NbChevaux - 4));
            }

            else
            {
                return 9 + ((float)0.0015 * (float)(NbChevaux - 4));
            }
            
        }

        public void Depanner()
        {
            Console.WriteLine("Depannage");
            prixVoyage += 100;
            FaireLePlein();
        }
        public void FaireLePlein()
        {
            Console.WriteLine("plein");
          prixVoyage+=(Reservoir.Remplir());
        }
    }
}