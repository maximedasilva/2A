using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {

            Cartes maCarte, maCarte2;
            maCarte = new Cartes("As", "Trefle");
            maCarte.affiche();
            maCarte2 = new Cartes("10");
            maCarte2.affiche();
            maCarte2.couleur = "Carreau";
            maCarte2.affiche();
        }
    }
}
