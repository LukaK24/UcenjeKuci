internal static class CIKLICNATABLICAHelpers
{

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




                }
            }


        }
        else if (smjer == 2)
        {
            while (broj <= redovi * kolone)
            {
                if (r >= 0 && r < redovi && c >= 0 && c < kolone && matrica[r, c] == 0)
                {
                    matrica[r, c] = broj++;
                }
            }

        }
    }
}