using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenje
{
    internal class GeneratorLozinke
    {

        public static void Izvedi() 
        {

            Console.WriteLine("Dobrodošli u generator lozinki!");
            Console.WriteLine("Unesite parametre prema kojima će program generirati lozinke.");

            // Unos parametara od korisnika
            int length = UnesiBroj("Unesite duzinu lozinke (min 8, max 64): ", 8, 64);
            bool includeUppercase = UnesiBoolean("Ukljuciti velika slova? (da/ne): ");
            bool includeLowercase = UnesiBoolean("Ukljuciti mala slova? (da/ne): ");
            bool includeDigits = UnesiBoolean("Ukljuciti brojeve? (da/ne): ");
            bool includePunctuation = UnesiBoolean("Ukljuciti interpunkcijske znakove? (da/ne): ");
            bool startsWithDigit = UnesiBoolean("Lozinka pocinje s brojem? (da/ne): ");
            bool startsWithPunctuation = UnesiBoolean("Lozinka pocinje s interpunkcijskim znakom? (da/ne): ");
            bool endsWithDigit = UnesiBoolean("Lozinka zavrsava s brojem? (da/ne): ");
            bool endsWithPunctuation = UnesiBoolean("Lozinka zavrsava s interpunkcijskim znakom? (da/ne): ");
            bool allowRepeats = UnesiBoolean("Lozinka ima ponavljajuce znakove? (da/ne): ");
            int numberOfPasswords = UnesiBroj("Unesite broj lozinki koje treba generirati: ", 1, 100);

            // Generiranje lozinki
            List<string> passwords = new List<string>();
            for (int i = 0; i < numberOfPasswords; i++)
            {
                string password = GenerirajLozinku(length, includeUppercase, includeLowercase,
                                                    includeDigits, includePunctuation, startsWithDigit,
                                                    startsWithPunctuation, endsWithDigit, endsWithPunctuation,
                                                    allowRepeats);
                passwords.Add(password);
            }

            // Ispis generiranih lozinki
            Console.WriteLine("\nGenerirane lozinke:");
            foreach (var pass in passwords)
            {
                Console.WriteLine(pass);
            }
        }

        // Funkcija za unos broja s provjerom
        static int UnesiBroj(string poruka, int min, int max)
        {
            int broj;
            while (true)
            {
                Console.Write(poruka);
                if (int.TryParse(Console.ReadLine(), out broj) && broj >= min && broj <= max)
                {
                    return broj;
                }
                else
                {
                    Console.WriteLine($"Neispravan unos. Unesite broj između {min} i {max}.");
                }
            }
        }

        // Funkcija za unos boolean vrijednosti (da/ne)
        static bool UnesiBoolean(string poruka)
        {
            while (true)
            {
                Console.Write(poruka);
                string odgovor = Console.ReadLine().ToLower();
                if (odgovor == "da")
                    return true;
                else if (odgovor == "ne")
                    return false;
                else
                    Console.WriteLine("Molimo odgovorite s 'da' ili 'ne'.");
            }
        }

        // Funkcija za generiranje lozinke
        static string GenerirajLozinku(int duzina, bool ukljuciVelika, bool ukljuciMala,
                                       bool ukljuciBrojeve, bool ukljuciInterpunkciju, bool pocinjeSBrojem,
                                       bool pocinjeSInterpunkcijom, bool zavrsavaSBrojem, bool zavrsavaSInterpunkcijom,
                                       bool dozvoliPonavljanje)
        {
            Random rand = new Random();
            StringBuilder lozinka = new StringBuilder();

            // Skupovi znakova za lozinku
            string malaSlova = "abcdefghijklmnopqrstuvwxyz";
            string velikaSlova = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string brojevi = "0123456789";
            string interpunkcija = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";

            string dostupniZnakovi = "";
            if (ukljuciMala) dostupniZnakovi += malaSlova;
            if (ukljuciVelika) dostupniZnakovi += velikaSlova;
            if (ukljuciBrojeve) dostupniZnakovi += brojevi;
            if (ukljuciInterpunkciju) dostupniZnakovi += interpunkcija;

            if (string.IsNullOrEmpty(dostupniZnakovi))
            {
                throw new ArgumentException("Morate odabrati barem jednu vrstu znakova.");
            }

            // Pravilo za početak lozinke
            if (pocinjeSBrojem)
            {
                lozinka.Append(brojevi[rand.Next(brojevi.Length)]);
            }
            else if (pocinjeSInterpunkcijom)
            {
                lozinka.Append(interpunkcija[rand.Next(interpunkcija.Length)]);
            }

            // Generiranje preostalih znakova lozinke
            while (lozinka.Length < duzina)
            {
                char sljedeciZnak;
                do
                {
                    sljedeciZnak = dostupniZnakovi[rand.Next(dostupniZnakovi.Length)];
                } while (!dozvoliPonavljanje && lozinka.ToString().Contains(sljedeciZnak.ToString()));

                lozinka.Append(sljedeciZnak);
            }

            // Pravilo za kraj lozinke
            if (zavrsavaSBrojem && lozinka.Length > 0)
            {
                lozinka[lozinka.Length - 1] = brojevi[rand.Next(brojevi.Length)];
            }
            else if (zavrsavaSInterpunkcijom && lozinka.Length > 0)
            {
                lozinka[lozinka.Length - 1] = interpunkcija[rand.Next(interpunkcija.Length)];
            }

            // Osigurati da je lozinka ispravne duljine
            if (lozinka.Length > duzina)
            {
                lozinka.Length = duzina; // Skraćivanje ako je duža od tražene dužine
            }

            return lozinka.ToString();
        }
    }
    
}
