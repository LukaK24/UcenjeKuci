using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ucenje
{
    internal class CIKLICNATABLICA
    {
        private static object martix;
        private static int c;

        public static void Izvedi() 
        {
             // unos dizmenije tablice
            
                int rows, cols;
            Console.Write("Unesite broj redova (2-50): ");

            while (int.TryParse(Console.ReadLine(), out rows) || rows < 2 || rows > 50) 
            {
                Console.WriteLine("Neispravan unos. Unesitze broj redova (2-50): ");
            
            }

            Console.Write("Unesite broj kolona (2-50): ");

            while (int.TryParse(Console.ReadLine(), out cols) || cols < 50) 
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

            int direction;
            Console.Write("Unesite broj smejra: ");
            while(int.TryParse(Console.ReadLine(),out direction) || direction < 1 || direction >16) 
            {
                Console.Write("Neispravan unos. Unesite broj smjera: ");
            }

            //generiranje matrice u odabranome smjeru

            int[,] matrix = new int[rows, cols];
            GeneriranjeMartix(martix, rows, cols, direction);

            //ispis matrice
            Printmatrix(matrix, rows, cols);

            //pitanje za ponovni unos
            Console.Write("Želite li napraviti još jednu matricu? (DA/NE): ");

            while (Console.ReadLine().ToUpper() == "DA") ;




        }

        private static void Printmatrix(int[,] matrix, int rows, int cols)
        {
            throw new NotImplementedException();
        }

        private static void GeneriranjeMartix(object martix, int rows, int cols, int direction)
        {
            throw new NotImplementedException();
        }

        public static void GeneriranjeMatrix(int[,] matrix, int rows, int cols, int direction) 
        {
            int num = 1;
            int r = 0, C = 0;

            //smjer 1- dolje desno početak u smjeru kazaljke na satu
            if (direction == 1) 
            {
                while (num <= rows * cols)
                {
                    if (r >= 0 && r < rows && C >= 0 && C < cols && matrix[r, c] == 0)
                    {
                        matrix[r, c] = num++;
                    }

                    //provjetra smejra dolje-desno

                    if (r + 1 < rows && c + 1 < cols && matrix[r + 1, c + 1] == 0)
                    {
                        r++;
                        C++;
                    }
                    else 
                    {
                        // ako ne mozemo dalje pomaknemo se u desno ili dolje
                        if (c + 1 < cols && matrix[r, c + 1] == 0)
                        {
                            c++;
                        }

                        else if (r + 1 < rows && matrix[r + 1, c] == 0)
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
