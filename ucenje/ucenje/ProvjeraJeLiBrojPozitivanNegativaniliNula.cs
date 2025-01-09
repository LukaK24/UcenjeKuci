using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenje
{
    internal class ProvjeraJeLiBrojPozitivanNegativaniliNula
    {
        public static void Izvedi() 
        {
            Console.Write("Unesite broj: ");
            double broj=Convert.ToDouble(Console.ReadLine());

            if(broj > 0) 
            {
                Console.WriteLine("Broj je pozitivan");
            }
            else if (broj < 0) 
            {
                Console.WriteLine("Broj je negativan");
            }
            else 
            {
                Console.WriteLine("Broj je nula");
            }
               
               
                
                
                

                    
                
            
            
        }
    }
}
