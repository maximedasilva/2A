using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Universites
{
    public abstract class Enseignant
    {
        protected string nom;
        protected static double prixHeureComplementaire = 35;
        protected int nbHeureTotal
        {
            get; set;
        }

        public Enseignant(string Nom, int nbHeure)
        {
            nom = Nom;
            nbHeureTotal = nbHeure;
        }

        public string getNom()
        {
            return nom;
        }

        public abstract int getHC();

        public abstract double getRemuneration();
        public override string ToString()
        {
            return (getRemuneration() + " " + nom);
        }
    }
}