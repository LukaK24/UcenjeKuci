using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ucenje
{
    internal class Prosjekocjena
    {
        private static void  Izvedi()
        {
            Console.WriteLine("Unesite broj ocjena: ");
            int brojOcjena=int.Parse(Console.ReadLine());

            for (int i = 0; i < brojOcjena;)
            {
                Console.WriteLine("Broj ocjena mora biti veći od 0.");
                return;
            }
            double zbrojOcjena = 0;

            for(int i = 0; i < brojOcjena; i++) 
            {
                Console.WriteLine("Unesite {i}. ocjenu: ");
                double ocjena = double.Parse(Console.ReadLine());
                zbrojOcjena += ocjena;
            }
            double prosjek = zbrojOcjena / brojOcjena;

            Console.WriteLine("Prosjek ocjena je: {prosjek:F2}");
        }
    }
}
