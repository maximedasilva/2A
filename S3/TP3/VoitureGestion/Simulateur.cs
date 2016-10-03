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
          
        }
        public void Demarrer(Voiture v)
        {
            Voiture = v;
            v.rouler(12000, 60);
        }
        public Voiture Voiture
        {
            get; set;
        }
       

       
    }
}