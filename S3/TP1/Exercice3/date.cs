using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    class Date
    {
        public int jour { get; set; }
        public int mois { get; set; }
        public int annee { get; set; }

        public Date(int _jour,int _mois,int _annee)
        {
            jour = _jour;
            mois = _mois;
            annee = _annee;
        }
        public int calculeDuree(Date d)
        {
            DateTime d1 = new DateTime(annee, mois, jour);
            DateTime d2 = new DateTime(d.annee, d.mois, d.jour);
            TimeSpan t = d1 - d2;
            return Math.Abs((d1.Date - d2.Date).Days);
            
        }
    }
}
