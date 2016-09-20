using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Universites
{
    public class Exterieurs : Enseignant
    {
        public Exterieurs(string Nom, int nbHeure):base(Nom,nbHeure)
        {
           
        }

        public override int getHC()
        {
            return nbHeureTotal;
        }

        public override double getRemuneration()
        {
            return (getHC() * Enseignant.prixHeureComplementaire);
        }
    }
    
}