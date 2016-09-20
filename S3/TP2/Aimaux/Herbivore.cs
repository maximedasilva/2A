using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aimaux
{
    class Herbivore: Animal
    {
        private string plante;
        public Herbivore(string _nom,string _plante):base(_nom)
        {
            plante = _plante;
        }
        public override string getInfo()
        {
            return nom + ", régime: " + plante;
        }
    }
}
