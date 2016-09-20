using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aimaux
{
    class Carnivore : Animal
    {
        List<Animal> proies;
        public Carnivore(string _nom,List<Animal> _proies):base(_nom)
        {
            proies = _proies;
        }
        public override string getInfo()
        {
            string animaux = "";
            if(proies.Count>0)
            foreach(var a in  proies)
            {
                animaux += a.nom + ", ";
            }
            return base.getInfo() + "\n Type: Carnivore \n Régime :" + animaux;
        }

    }
}
