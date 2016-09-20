using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Universites
{
    public abstract class Enseignant
    {
        protected string nom;
        protected static double prixHeureComplementaire;

        public int nbHeureComplementaire
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public string getNom()
        {
            return "";
        }

        public abstract double getHC();

        public abstract double getRemuneration();
    }
}