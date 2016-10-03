using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VoitureGestion
{
    public class Voiture
    {
        private int numVoiture;
        public float prixVoyage { get; set; }
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

        public float Vitesse
        {
            get; set;
        }

        public int NbChevaux
        {
            get; set;
        }

        public void rouler()
        {
            throw new System.NotImplementedException();
        }

        public float Conso()
        {
            if(Vitesse<80)
            {
                return 6 + ((float)0.15 * (float)(NbChevaux - 4));
            }

            else if (Vitesse > 80 && Vitesse < 100)
            {
                return 7 + ((float)0.15 * (float)(NbChevaux - 4));
            }

            else if (Vitesse > 100 && Vitesse < 120)
            {
                return 8 + ((float)0.15 * (float)(NbChevaux - 4));
            }

            else
            {
                return 9 + ((float)0.15 * (float)(NbChevaux - 4));
            }
            
        }

        public void Depanner()
        {
            prixVoyage += 100;
            FaireLePlein();
        }
        public void FaireLePlein()
        {
          prixVoyage+=(Reservoir.Remplir());
        }
    }
}