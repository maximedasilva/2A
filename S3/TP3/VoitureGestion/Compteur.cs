using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VoitureGestion
{
    public class Compteur
    {
        public Compteur()
        {
            Vitesse = 0;
            NbKilometresParcourus = 0;
        }

        public double Vitesse
        {
            get; set;
        }

        public int NbKilometresParcourus
        {
            get; set;
        }

        public int getNumVoiture()
        {
            throw new System.NotImplementedException();
        }
    }
}