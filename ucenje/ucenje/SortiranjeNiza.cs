using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenje
{
    internal class SortiranjeNiza
    {
        public static void Izvedi() 
        {
            //trazimo od korisnika da unese roj elementa u nizu
            Console.WriteLine("Unesite broj elementa u nizu: ");
            int n=Convert.ToInt32(Console.ReadLine());

            //deklariramo niz cijelih brojeva
            int[] brojevi = new int[n];


            //unos vrijednosti u niz
            Console.WriteLine("Unesite elemente niza: ");
            for (int i = 0; i < n; i++) 
            {
                Console.Write($"Unesite element {i + 1}: ");
                brojevi[i] = Convert.ToInt32(Console.ReadLine());
            }
            //sortiranje niza ulazno
            Array.Sort(brojevi);

            //ispis sortiranja niza
            Console.WriteLine("\nSortirani niz (uzlazno): ");
            foreach(int broj in brojevi) 
            {
                Console.Write(broj + " ");
            }
        }


    }
}
