using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2
{
    class MicroOrdinateur
    {
        private string processeur;
        private int RAM;
        private int hd;
        private double prix;

        public MicroOrdinateur(string _Processeur,int _RAM,int _hd, double _prix)
        {
            processeur = _Processeur;
            RAM = _RAM;
            hd = _hd;
            prix = _prix;
        }
    }
}
