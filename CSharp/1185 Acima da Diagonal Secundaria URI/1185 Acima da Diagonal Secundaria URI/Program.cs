using System;

namespace _1185_Acima_da_Diagonal_Secundaria_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            string op = Console.ReadLine();
            double[,] arr = new double[12, 12];
            double sum = 0;
            int p =10;


            for (int x = 0; x < 12; x++)
            {
                for (int y = 0; y < 12; y++)
                {
                    arr[x, y] = double.Parse(Console.ReadLine());
                    //coluna = x
                    //linha = y
                }
            }
            for (int z = 0; z < 11; z++)
            {
                for (int w = 0; w <= p; w++)
                {
                    sum += arr[z, w];
                }
                p--;
            }
            if (op.Equals("S"))
            {
                string final = string.Format("{0:0.0}", sum);
                final = final.Replace(",", ".");
                Console.WriteLine(final);
            }
            else if (op.Equals("M"))
            {
                double r = sum / 66.0;
                string final = string.Format("{0:0.0}", r);
                final = final.Replace(",", ".");
                Console.WriteLine(final);
            }
        }
    }
}