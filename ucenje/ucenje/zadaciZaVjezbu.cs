using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ucenje
{
    internal class zadaciZaVjezbu
    {

        public static void Izvedi() 
        {
            //Trazimo unos duljine
            Console.WriteLine("Unesite duljinu pravokutnika: ");
            double duljina=Convert.ToDouble(Console.ReadLine());

            //Trazimo unos sirine
            Console.WriteLine("Unesite širinu pravokutnika: ");
            double sirina =Convert.ToDouble(Console.ReadLine());

            //Izracunava povrsinu pravoktunika
            double povrsina = duljina * sirina;

            Console.WriteLine($"Površina pravokutnika je: {povrsina:F2}");
            
                
            
                 
            
                
            
                
                
            
            

        }
    }
}
