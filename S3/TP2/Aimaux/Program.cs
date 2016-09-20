using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aimaux
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal("chat");
            Animal b = new Animal("souris");
            List<Animal> proies = new List<Animal>();
            proies.Add(a);
            proies.Add(b);
            Animal c = new Carnivore("tigre",proies);
            Console.WriteLine(c.getInfo());
            Animal i = new Herbivore("elephant", "Bambou");
        }
    }
}
