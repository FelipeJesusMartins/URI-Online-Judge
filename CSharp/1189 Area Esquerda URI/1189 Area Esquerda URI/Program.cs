using System;

namespace _1189_Area_Esquerda_URI
{
    class Program
    {

        static void Main(string[] args)
        {
            string op = Console.ReadLine();
            double[,] arr = new double[12, 12];
            double sum = 0;
            int p = 4;
            int r = 0;


            for (int x = 0; x < 12; x++)
            {
                for (int y = 0; y < 12; y++)
                {
                    arr[x, y] = double.Parse(Console.ReadLine());
                }
            }
            //linha
            for (int z = 1; z < 11; z++)
            {
                if (z < 6)
                {
                    //coluna
                    for (int w = 0; w <= r; w++)
                    {
                        sum += arr[z, w];
                    }
                    r++;
                }
                else if (z > 5)
                {
                    for (int w = 0; w <= p; w++)
                    {
                        sum += arr[z, w];
                    }
                    p--;
                }

            }
            if (op.Equals("S"))
            {
                string final = string.Format("{0:0.0}", sum);
                final = final.Replace(",", ".");
                Console.WriteLine(final);
            }
            else if (op.Equals("M"))
            {
                double f = sum / 30.0;
                string final = string.Format("{0:0.0}", f);
                final = final.Replace(",", ".");
                Console.WriteLine(final);
            }
        }
    }
}