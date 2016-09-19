using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            Deplacement d1 = new Deplacement(new Date(1, 9, 2016), new Date(4, 9, 2016),"marseille"," visite Client");
            Deplacement d2 = new Deplacement(new Date(2, 7, 2016), new Date(4, 7, 2016), "Londres", "Réunion");
            d1.afficherCaractéristique();
            d2.afficherCaractéristique();
            
        }
    }
}
