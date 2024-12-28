using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenje
{
    internal class Zbrojelemenataniza
    {
        private static int brojElemnata;

        public static void Izvedi() 
        {
            Console.WriteLine("Unesite broj elementa niza: ");
            int brojElemenata=Convert.ToInt32(Console.ReadLine());

            

            int[] niz= new int[brojElemenata];

            for(int i = 0; i < brojElemenata; i++) 
            {
                Console.WriteLine($"Unesite elemnt {i+1}: ");
                niz[i]= Convert.ToInt32(Console.ReadLine());
            }
            int zbroj = 0;
            for(int i = 0;i < brojElemenata; i++) 
            {
                zbroj += niz[i];
            }

            Console.WriteLine("Zbroj svih elmenata niza je {}");
        }
    }
}
