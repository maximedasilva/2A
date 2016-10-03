using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoitureGestion
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulateur s = new Simulateur();
            Voiture v = new Voiture(6, 1);
            s.Demarrer(v);
            Console.WriteLine(v.prixVoyage);
        }
    }
}
