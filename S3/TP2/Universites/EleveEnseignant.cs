using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Universites
{
    public class EleveEnseignant : Enseignant
    {
        public static int nbHeureMaxEnseignement { get; set; } = 96;
        public EleveEnseignant(string Nom, int nbHeure):base(Nom,nbHeure)
        {
            
        }

        public override int getHC()
        {
            if(nbHeureTotal<nbHeureMaxEnseignement)
            { return nbHeureTotal;
            }
            else
            {
                nbHeureTotal = nbHeureMaxEnseignement;
                    return nbHeureTotal;
            }
        }

        public override double getRemuneration()
        {
            return Enseignant.prixHeureComplementaire * getHC()*0.18;
        }
    }
}