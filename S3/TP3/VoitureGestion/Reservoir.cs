using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VoitureGestion
{
    public class Reservoir
    {
        public Reservoir(int puissance)
        {
            capacite = puissance;
        }

        public int capacite
        {
            get; set;
        }

        public int QuantiteActuelle
        {
            get; set;
        }

        public float Remplir()
        {
            float aRemplir = capacite - QuantiteActuelle;
            QuantiteActuelle = capacite;
            return aRemplir;
        }

        public int distanceMaxi()
        {
            throw new System.NotImplementedException();
        }
    }
}