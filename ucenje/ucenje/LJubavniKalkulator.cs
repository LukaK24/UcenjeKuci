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
            Console.WriteLine("Dobrodošli u ljubavni kalkulator!");
            Console.WriteLine("Ovaj kalkulator izračunava kompatibilnost između vas i vaše simpatije na temelju slova u imenima.\n");

            
            Console.WriteLine("Unesite svoje ime (samo slova):");
            string mojeIme = UnesiIme();

            Console.WriteLine("Unesite ime svoje simpatije (samo slova):");
            string simpatijaIme = UnesiIme();

           
            Console.WriteLine($"\nVaše ime: {mojeIme}");
            Console.WriteLine($"Ime simpatije: {simpatijaIme}");

            
            string kombinacijaImena = mojeIme.ToLower() + simpatijaIme.ToLower();
            Console.WriteLine($"\nKombinacija imena (za analizu): {kombinacijaImena}");

            
            List<int> brojevi = BrojiSlova(kombinacijaImena);
            Console.WriteLine($"Brojevi dobiveni iz kombinacije: {string.Join(", ", brojevi)}");

            
            Console.WriteLine("\nProces izračunavanja kompatibilnosti započinje:");
            int ljubavnaSansa = IzracunajLjubavRekurzija(brojevi);

            
            Console.WriteLine($"\nVaša šansa za ljubav sa simpatijom je: {ljubavnaSansa}%");
            PrikaziZakljucak(ljubavnaSansa);

            
            Console.WriteLine("\nŽelite li pokušati s drugim imenom? (da/ne)");
            string odgovor = Console.ReadLine()?.ToLower();
            if (odgovor == "da")
            {
                Izvedi(); 
            }
            else
            {
                Console.WriteLine("Hvala što ste koristili ljubavni kalkulator! Sretno u ljubavi! ❤️");
            }
        }

        static string UnesiIme()
        {
            string ime;
            while (true)
            {
                ime = Console.ReadLine();
                if (!string.IsNullOrEmpty(ime) && ime.All(char.IsLetter))
                    return ime;

                Console.WriteLine("Pogrešan unos! Molimo unesite ispravno ime (samo slova):");
            }
        }

        static List<int> BrojiSlova(string tekst)
        {
            Console.WriteLine("\nPrebrojavanje slova u kombinaciji imena...");
            var ponavljanja = tekst.GroupBy(slovo => slovo)
                                   .Select(grupa => grupa.Count())
                                   .ToList();

            foreach (var grupa in tekst.GroupBy(slovo => slovo))
            {
                Console.WriteLine($"Slovo '{grupa.Key}' pojavljuje se {grupa.Count()} puta.");
            }

            return ponavljanja;
        }

        static int IzracunajLjubavRekurzija(List<int> brojevi)
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

           
            Console.WriteLine($"Trenutni brojevi: {string.Join(", ", noviBrojevi)}");

          
            return IzracunajLjubavRekurzija(noviBrojevi);
        }

        static void PrikaziZakljucak(int sansa)
        {
            Console.WriteLine("\nLjubavni zaključak:");
            if (sansa >= 90)
            {
                Console.WriteLine("Vi i vaša simpatija ste savršen par! ❤️");
            }
            else if (sansa >= 70)
            {
                Console.WriteLine("Izgleda da postoji jaka povezanost! Vrijedi pokušati.");
            }
            else if (sansa >= 50)
            {
                Console.WriteLine("Postoji šansa za ljubav, ali trebat će malo truda.");
            }
            else
            {
                Console.WriteLine("Šanse nisu velike, ali nikad ne recite nikad. Ljubav je nepredvidiva!");
            }
            
        }
    }
    
}
