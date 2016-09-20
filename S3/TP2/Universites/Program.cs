using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universites
{
    class Program
    {
        static void Main(string[] args)
        {
            Enseignant jackDaniel = new Engage("Jacques Daniel",600);
            Console.WriteLine(jackDaniel);
            Enseignant d = new EleveEnseignant("coucou", 600);
            Enseignant f = new Exterieurs("test", 600);
            Console.WriteLine(d);
            Console.WriteLine(f);
        }

    }
}
