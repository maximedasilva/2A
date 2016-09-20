using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Universites
{
    public class Engage : Enseignant
    {
        public double salireBase { get; set; } =1500;
        public Engage(string Nom, int nbHeure):base(Nom,nbHeure)
        {

        }

        public static int QuotaHeureNormales
        {
            get; set;
        } = 192;

        public override int getHC()
        {
            if (nbHeureTotal - QuotaHeureNormales > 0)
                return nbHeureTotal - QuotaHeureNormales;
            else return 0;
        }

        public override double getRemuneration()
        {
            return salireBase+ getHC() * Enseignant.prixHeureComplementaire;
        }
    }
}