using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VoitureGestion
{
    public class Simulateur
    {
        public Simulateur()
        {
            Voiture = new Voiture(_nbChevaux, _num);
        }

        public Voiture Voiture
        {
            get;
        }

        public float PrixVoyage()
        {
            throw new System.NotImplementedException();
        }

        public void Depanner()
        {
            throw new System.NotImplementedException();
        }
    }
}