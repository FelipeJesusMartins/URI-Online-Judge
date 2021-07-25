using System;

namespace _1187_Area_Superior_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            string op = Console.ReadLine();
            double[,] arr = new double[12, 12];
            double sum = 0;
            uint p = 10;


            for (int x = 0; x < 12; x++)
            {
                for (int y = 0; y < 12; y++)
                {
                    arr[x, y] = double.Parse(Console.ReadLine());
                }
            }
            //linha
            for (int z = 0; z < 5; z++)
            {
                //coluna
                for (int w = z+1; w <= p; w++)
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
                double r = sum / 30.0;
                string final = string.Format("{0:0.0}", r);
                final = final.Replace(",", ".");
                Console.WriteLine(final);
            }
        }
    }
}