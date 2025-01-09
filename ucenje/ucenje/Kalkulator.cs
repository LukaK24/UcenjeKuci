using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenje
{
    internal class Kalkulator
    {
        public static void Izvedi() 
        {
            //trazimo od korisnika da unese prvi broj
            Console.WriteLine("Unesite prvi broj: ");
            double broj1 =Convert.ToDouble(Console.ReadLine());

            //trazimo od korisnika da unese drugi broj
            Console.WriteLine("Unesite drugi broj: ");
            double broj2 =Convert.ToDouble(Console.ReadLine());

            //trazimo od korisnika da unese operaciju
            Console.Write("Unesite operaciju (+, -, *, /): ");
            string operacija =Console.ReadLine();

            //izracun i ispis rezultata koristeci switch 
            double rezultat = 0;
            bool IspravanOdabir = true;

            switch (operacija) 
            {

                case "+":
                    rezultat =broj1 + broj2;
                    break;
                case "-":
                    rezultat = broj1 - broj2;
                    break;
                case "*":
                    rezultat = broj1 * broj2;
                    break;
                case "/":

                    // Provjeravamo da li je drugi broj 0 prije nego sto pokusamo dijeljenje
                    if (broj2 != 0)
                    {
                        rezultat = broj1 / broj2;
                    }
                    else
                    {
                        Console.WriteLine("Greška: Dijeljenje s nulom nije dozvoljeno.");
                        IspravanOdabir = false;
                    }
                    break;
                default:
                    Console.WriteLine("Greška: Nevažeća operacija.");
                    IspravanOdabir = false;
                    break;

            }
            // Ispisujemo rezultat ako je operacija valjana
            if (IspravanOdabir)
            {
                Console.WriteLine($"Rezultat: {rezultat}");
            }
        }
    }
}
