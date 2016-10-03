using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VoitureGestion
{
    public class Voiture
    {
        private int numVoiture;

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

        public int Conso()
        {
            throw new System.NotImplementedException();
        }

        public void FaireLePlein()
        {
            throw new System.NotImplementedException();
        }
    }
}