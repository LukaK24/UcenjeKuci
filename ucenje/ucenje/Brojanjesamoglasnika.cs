using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenje
{
    internal class Brojanjesamoglasnika
    {
        public static void Izvedi() 
        {
            //Ispisivanje pozdrava i upute korisniku
            Console.WriteLine("Dobro došli u program za prebrojavanje samoglasnika");
            Console.WriteLine("Unesite string: ");

            //Unos stringa od strane korisnika
            string unos=Console.ReadLine();


            //prebrojavanje samoglasnika
            int brojSamoglasnika = 0;
            string samoglasnici = "aeiouAEIOU";  //Samoglasnici u velikim i malim slovima


            foreach(char znak in unos) 
            {
                if (samoglasnici.Contains(znak)) 
                {
                
                brojSamoglasnika++;
                }

                Console.WriteLine($"U unesenom stringu ima {brojSamoglasnika} samoglasnika");
                
            }
                
                
        }
    }
}
