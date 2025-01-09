using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenje
{
    internal class Pretvorbatemperature
    {
        public static void Izvedi() 
        {
            //Ispisivanj uputa korisniku
            Console.WriteLine("Dobrodošli u program za pretvorbu temperature");
            Console.WriteLine("Odaberite vrstu pretvorbe:");
            Console.WriteLine("1. Celzijus u Fahrenheit");
            Console.WriteLine("2. Fahrenheit u Celzijus");


            //unos izbora korisnika
            int odabir;
            bool ispravanOdabir = false;


            //provjera da unos bude valjan
            while (!ispravanOdabir) 
            {
                Console.Write("Unesite 1 ili 2");
                ispravanOdabir = int.TryParse(Console.ReadLine(), out odabir) && (odabir == 1);



                //ovisno o odabiru vrsi se odgovarajuca pretvorba
                if(odabir == 1) 
                {
                    //pretvorba celzijusa u fahrenheit
                    Console.Write("Unesite temperaturu u Celzijusima");
                    double celsius =Convert.ToDouble(Console.ReadLine());
                    double fahrenheit = (celsius * 9 / 5) + 32;
                    Console.WriteLine($"{celsius} °C ={fahrenheit} °F" );

                
                }
                else if(odabir == 2) 
                {
                    //pretvorba fahrenheita u celziuse
                    Console.Write("Unesite temperaturu u Fahrenheitima: ");
                    double fahrenheit=Convert.ToDouble(Console.ReadLine());
                    double celsius = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine($"{fahrenheit} °F= {celsius}°C ");
                }
            } 

        }
    }
}
