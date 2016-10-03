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
            if (puissance <= 6)
            {
                capacite = 40;
            }
            else
                capacite = 60;
            QuantiteActuelle = capacite;
        }

        public double capacite
        {
            get; set;
        }

        public double QuantiteActuelle
        {
            get; set;
        }

        public double Remplir()
        {
            double aRemplir = capacite - QuantiteActuelle;
            QuantiteActuelle = capacite;
            return aRemplir;
        }

        public double distanceMaxi(double conso)
        {
            return (QuantiteActuelle / conso)*100;
        }
    }
}