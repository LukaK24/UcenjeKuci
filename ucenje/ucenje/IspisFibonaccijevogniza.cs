using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ucenje
{
    internal class IspisFibonaccijevogniza
    {
        public static void Izvedi()
        {
            //Console.WriteLine("B");
            Console.WriteLine("Unesite broj n: ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0) 
            {
                Console.WriteLine("Broj n mora biti veci od 0.");
                return;
            } 
            long a=0, b=1;
            Console.WriteLine("Prvih {0} brojeva Fibonaccijevogniza:", n);

            for (int i = 0; i < n; i++) 
            {
                Console.Write(a+ " ");

                long temp = a;
                a=b;
                b = temp + b;
            }
            Console.WriteLine();    
        }
    }
}
