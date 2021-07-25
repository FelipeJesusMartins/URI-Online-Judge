using System;

namespace _1188_Area_Inferior_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            string op = Console.ReadLine();
            double[,] arr = new double[12, 12];
            double sum = 0;
            int p = 5;
            int r = 6;


            for (int x = 0; x < 12; x++)
            {
                for (int y = 0; y < 12; y++)
                {
                    arr[x, y] = double.Parse(Console.ReadLine());
                }
            }
            //linha
            for (int z = 7; z < 12; z++)
            {
                //coluna
                for (int w = p; w <= r; w++)
                {
                        sum += arr[z, w];
                }
                p--;
                r++;
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