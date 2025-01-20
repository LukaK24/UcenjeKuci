using System.ComponentModel.Design;

namespace ucenje
{
    internal class CIKLICNATABLICA
    {
        private static object martix;
        private static int c;
        private static int broj;
        private static object matrica;

        public static void Izvedi() 
        {

            bool ponovo = true;

            while (ponovo)
            {
                // Unos dimenzija matrice
                int redovi = 0, kolone = 0;
                while (redovi < 2 || redovi > 50)
                {
                    Console.Write("Unesite broj redova (2 do 50): ");
                    redovi = int.Parse(Console.ReadLine());
                }
                while (kolone < 2 || kolone > 50)
                {
                    Console.Write("Unesite broj kolona (2 do 50): ");
                    kolone = int.Parse(Console.ReadLine());
                }

                // Unos smjera
                Console.WriteLine("Odaberite smjer kretanja brojeva:");
                Console.WriteLine("1. dolje desno početak u smjeru kazaljke na satu");
                Console.WriteLine("2. dolje lijevo početak u smjeru kazaljke na satu");
                Console.WriteLine("3. gore lijevo početak u smjeru kazaljke na satu");
                Console.WriteLine("4. gore desno početak u smjeru kazaljke na satu");
                Console.WriteLine("5. dolje desno početak u kontra smjeru kazaljke na satu");
                Console.WriteLine("6. dolje lijevo početak u kontra smjeru kazaljke na satu");
                Console.WriteLine("7. gore lijevo početak u kontra smjeru kazaljke na satu");
                Console.WriteLine("8. gore desno početak u kontra smjeru kazaljke na satu");
                Console.WriteLine("9. sredina lijevo u smjeru kazaljke na satu");
                Console.WriteLine("10. sredina desno u smjeru kazaljke na satu");
                Console.WriteLine("11. sredina gore u smjeru kazaljke na satu");
                Console.WriteLine("12. sredina dolje u smjeru kazaljke na satu");
                Console.WriteLine("13. sredina lijevo u kontra smjeru kazaljke na satu");
                Console.WriteLine("14. sredina desno u kontra smjeru kazaljke na satu");
                Console.WriteLine("15. sredina gore u kontra smjeru kazaljke na satu");
                Console.WriteLine("16. sredina dolje u kontra smjeru kazaljke na satu");
                Console.Write("Odaberite broj smjera: ");
                int smjer = int.Parse(Console.ReadLine());

                // Inicijalizacija matrice
                int[,] matrix = new int[redovi, kolone];
                int num = 1;  
                int r = 0, c = 0;  

                // Popunjava matrica prema odabranom smjeru
                switch (smjer)
                {
                    case 1: // dolje desno početak u smjeru kazaljke na satu
                        r = 0; c = 0;
                        break;
                    case 2: // dolje lijevo početak u smjeru kazaljke na satu
                        r = 0; c = kolone - 1;
                        break;
                    case 3: // gore lijevo početak u smjeru kazaljke na satu
                        r = redovi - 1; c = kolone - 1;
                        break;
                    case 4: // gore desno početak u smjeru kazaljke na satu
                        r = redovi - 1; c = 0;
                        break;
                    case 5: // dolje desno početak u kontra smjeru kazaljke na satu
                        r = 0; c = 0;
                        break;
                    case 6: // dolje lijevo početak u kontra smjeru kazaljke na satu
                        r = 0; c = kolone - 1;
                        break;
                    case 7: // gore lijevo početak u kontra smjeru kazaljke na satu
                        r = redovi - 1; c = kolone - 1;
                        break;
                    case 8: // gore desno početak u kontra smjeru kazaljke na satu
                        r = redovi - 1; c = 0;
                        break;
                    case 9: // sredina lijevo u smjeru kazaljke na satu
                        r = redovi / 2; c = 0;
                        break;
                    case 10: // sredina desno u smjeru kazaljke na satu
                        r = redovi / 2; c = kolone - 1;
                        break;
                    case 11: // sredina gore u smjeru kazaljke na satu
                        r = 0; c = kolone / 2;
                        break;
                    case 12: // sredina dolje u smjeru kazaljke na satu
                        r = redovi - 1; c = kolone / 2;
                        break;
                    case 13: // sredina lijevo u kontra smjeru kazaljke na satu
                        r = redovi / 2; c = 0;
                        break;
                    case 14: // sredina desno u kontra smjeru kazaljke na satu
                        r = redovi / 2; c = kolone - 1;
                        break;
                    case 15: // sredina gore u kontra smjeru kazaljke na satu
                        r = 0; c = kolone / 2;
                        break;
                    case 16: // sredina dolje u kontra smjeru kazaljke na satu
                        r = redovi - 1; c = kolone / 2;
                        break;
                }

                // Punjenje matrice
                for (int i = 0; i < redovi; i++)
                {
                    for (int j = 0; j < kolone; j++)
                    {
                        matrix[r, c] = num++;
                        
                        // Pomicanje na sljedeću poziciju ovisno o smjeru
                        if (smjer == 1 || smjer == 5) { r++; c++; }
                        else if (smjer == 2 || smjer == 6) { r++; c--; }
                        else if (smjer == 3 || smjer == 7) { r--; c--; }
                        else if (smjer == 4 || smjer == 8) { r--; c++; }
                        
                    }
                }

                // Ispis matrice sa formatiranjem
                for (int i = 0; i < redovi; i++)
                {
                    for (int j = 0; j < kolone; j++)
                    {
                        Console.Write($"{matrix[i, j],5} ");  
                    }
                    Console.WriteLine();
                }

                // Pitanje korisniku želi li ponovno generirati matricu
                Console.Write("Želite li generirati novu matricu? (DA/NE): ");
                string odgovor = Console.ReadLine().ToUpper();
                if (odgovor == "NE")
                {
                    ponovo = false;
                }
            }




        }

  
         
    }
}
