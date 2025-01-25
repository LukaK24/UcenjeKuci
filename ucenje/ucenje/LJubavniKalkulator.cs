using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenje
{
    class LJubavniKalkulator
    {
        public static void Izvedi() 
        {

            Console.WriteLine("Dobrodošli u ljubavni kalkulator s rekurzijom!");
            Console.WriteLine("Unesite svoje ime (samo slova):");
            string mojeIme = UnesiIme();

            Console.WriteLine("Unesite ime svoje simpatije (samo slova):");
            string simpatijaIme = UnesiIme();

           
            string kombinacijaImena = mojeIme.ToLower() + simpatijaIme.ToLower();

           
            List<int> brojevi = BrojiSlova(kombinacijaImena);
            Console.WriteLine("\nPočetni brojevi: " + string.Join(", ", brojevi));

           
            int ljubavnaSansa = IzracunajLjubav(brojevi);

         
            Console.WriteLine($"\nVaša šansa za ljubav sa simpatijom je: {ljubavnaSansa}%");
            PrikaziZakljucak(ljubavnaSansa);
        }

       
        static string UnesiIme()
        {
            string ime;
            while (true)
            {
                ime = Console.ReadLine();
                if (!string.IsNullOrEmpty(ime) && ime.All(char.IsLetter))
                    break;
                Console.WriteLine("Pogrešan unos! Molimo unesite ispravno ime (samo slova):");
            }
            return ime;
        }

     
        static List<int> BrojiSlova(string tekst)
        {
            Dictionary<char, int> ponavljanja = new Dictionary<char, int>();
            foreach (char slovo in tekst)
            {
                if (ponavljanja.ContainsKey(slovo))
                    ponavljanja[slovo]++;
                else
                    ponavljanja[slovo] = 1;
            }
            return ponavljanja.Values.ToList();
        }

        static int IzracunajLjubav(List<int> brojevi)
        {
            if (brojevi.Count == 2)
            {
                
                return brojevi[0] * 10 + brojevi[1];
            }

           
            List<int> noviBrojevi = new List<int>();
            for (int i = 0; i < brojevi.Count - 1; i++)
            {
                int zbroj = brojevi[i] + brojevi[i + 1];
                noviBrojevi.Add(zbroj % 10); 
            }

            
            Console.WriteLine("Trenutni brojevi: " + string.Join(" | ", noviBrojevi));
            return IzracunajLjubav(noviBrojevi);
        }

      
        static void PrikaziZakljucak(int sansa)
        {
            if (sansa >= 80)
            {
                Console.WriteLine("Izgleda da je ljubav između vas dvoje suđena!");
            }
            else if (sansa >= 50)
            {
                Console.WriteLine("Postoji dobra šansa za ljubav. Dajte sve od sebe!");
            }
            else
            {
                Console.WriteLine("Šanse su male, ali ne gubite nadu! Ljubav uvijek može iznenaditi.");
            }
        }
    }
    
}
