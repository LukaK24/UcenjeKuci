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
             // unos dizmenije tablice
            
                int redovi, kolone;
            Console.Write("Unesite broj redova (2-50): ");

            while (int.TryParse(Console.ReadLine(), out redovi) || redovi < 2 || redovi > 50) 
            {
                Console.WriteLine("Neispravan unos. Unesitze broj redova (2-50): ");
            
            }

            Console.Write("Unesite broj kolona (2-50): ");

            while (int.TryParse(Console.ReadLine(), out kolone) || kolone < 50) 
            {
                Console.Write("Neispravan unos. Unesite broj kolona (2-50): ");
            }

            // unos smjerova
            Console.WriteLine("1. Dolje desno početak u smjeru kazaljke na satu");
            Console.WriteLine("2. Dolje lijevo početak u smjeru kazaljke na satu");
            Console.WriteLine("3. Gore lijevo početak u smjeru kazaljke na satu");
            Console.WriteLine("4. Gore desno početak u smjeru kazaljke na satu");
            Console.WriteLine("5. Dolje desno početak u kontra smjeru kazaljke na satu");
            Console.WriteLine("6. Dolje lijevo početak u kontra smjeru kazaljke na satu");
            Console.WriteLine("7. Gore lijevo početak u kontra smjeru kazaljke na satu");
            Console.WriteLine("8. Gore desno početak u kontra smjeru kazaljke na satu");
            Console.WriteLine("9. Sredina lijevo u smjeru kazaljke na satu");
            Console.WriteLine("10. Sredina desno u smjeru kazaljke na satu");
            Console.WriteLine("11. Sredina gore u smjeru kazaljke na satu");
            Console.WriteLine("12. Sredina dolje u smjeru kazaljke na satu");
            Console.WriteLine("13. Sredina lijevo u kontra smjeru kazaljke na satu");
            Console.WriteLine("14. Sredina desno u kontra smjeru kazaljke na satu");
            Console.WriteLine("15. Sredina gore u kontra smjeru kazaljke na satu");
            Console.WriteLine("16. Sredina dolje u kontra smjeru kazaljke na satu");

            int smjer;
            Console.Write("Unesite broj smejra: ");
            while(int.TryParse(Console.ReadLine(),out smjer) || smjer < 1 || smjer >16) 
            {
                Console.Write("Neispravan unos. Unesite broj smjera: ");
            }

            //generiranje matrice u odabranome smjeru

            int[,] matrix = new int[redovi, kolone];
            GeneriranjeMartix(martix, redovi, kolone, smjer);

            //ispis matrice
            Printmatrix(matrix, redovi , kolone );

            //pitanje za ponovni unos
            Console.Write("Želite li napraviti još jednu matricu? (DA/NE): ");

            while (Console.ReadLine().ToUpper() == "DA") ;




        }

        private static void Printmatrix(int[,] matrix, int redovi, int kolone)
        {
            throw new NotImplementedException();
        }

        private static void GeneriranjeMartix(object martix, int redovi, int kolone, int smjer)
        {
            throw new NotImplementedException();
        }

        public static void GeneriranjeMatrix(int[,] matrix, int redovi, int kolone, int smjer) 
        {
            int num = 1;
            int r = 0, C = 0;

            //smjer 1- dolje desno početak u smjeru kazaljke na satu
            if (smjer == 1) 
            {
                while (num <= redovi * kolone)
                {
                    if (r >= 0 && r < redovi && C >= 0 && C < kolone && matrix[r, c] == 0)
                    {
                        matrix[r, c] = num++;
                    }

                    //provjetra smejra dolje-desno

                    if (r + 1 < redovi && c + 1 < kolone && matrix[r + 1, c + 1] == 0)
                    {
                        r++;
                        C++;
                    }
                    else 
                    {
                        // ako ne mozemo dalje pomaknemo se u desno ili dolje
                        if (c + 1 < kolone && matrix[r, c + 1] == 0)
                        {
                            c++;
                        }

                        else if (r + 1 < redovi && matrix[r + 1, c] == 0)
                        {
                            r++;
                        }
                        else 
                        {
                        break;
                        }

                        if (smjer == 2) 
                        {
                        while (broj <= redovi * kolone) 
                            {
                                if (r >= 0 && r < redovi && c >= 0 && c < kolone && matrix[r, c] == 0)
                                {
                                    matrix[r, c] = broj++;
                                }
                                // provjera smjera dolje lijevo
                                if (r + 1 < redovi && c - 1 >= 0 && matrix[r + 1, c - 1] == 0)
                                {
                                    r++;
                                    c--;

                                }
                                else 
                                {
                                    // ako ne mozemo dalje pomaknemo se u lijevo ili dolje
                                    if (c - 1 >= 0 && matrix[r, c - 1] == 0) 
                                    {

                                        c--;
                                    }
                                    else  if (r + 1 < redovi && matrix[r + 1,c] == 0) 
                                    {
                                        r++;
                                    }
                                    else 
                                    {

                                        break;
                                    
                                    }
                                    
                                
                                }
                            }
                        }
                        

                     
                    }
                }

               
            }

        }
         
    }
}
