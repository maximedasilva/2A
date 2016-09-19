using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2
{
   public  class MicroOrdinateurTest
    {

        private MicroOrdinateur ord1, ord2;
        public MicroOrdinateurTest()
            {
            ord1 = new MicroOrdinateur("Intel Core I3", 10000, 8000, 400);
            ord2 = new MicroOrdinateur("AMD", 16000, 40000, 800);
            test();
        }
        public void test()
        {
            string reponses="";
            if (!ord1.estCompatibleDualBoot() && !ord1.estOKPourDevLinux()&& ord2.estOKPourDevLinux()&& ord2.estOKPourDevLinux())
                reponses += "OK \n";
            else
                reponses += "ERREUR";
            Console.WriteLine(reponses);
        }
    }
}
