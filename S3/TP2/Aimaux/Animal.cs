using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aimaux
{
    class Animal
    {
        public string nom;
        public Animal(string _nom)
        {
            nom = _nom;
        }
            public virtual string getInfo()
        { 
            return "Nom de l'animal "+nom;
        }
        


       
    }
}
