using System;

namespace _1182_Coluna_na_Matriz_URI
{
    class Program
    {
         static void Main(string[] args)
        {
            int arrColumn = int.Parse(Console.ReadLine());
            string op = Console.ReadLine();
            double[,] arr = new double[12, 12];
            double sum = 0;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    arr[i, j] = double.Parse(Console.ReadLine());
                    if (j == arrColumn)
                    {
                        sum += arr[i, j];
                    }
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
                double r = sum / 12.0;
                string final = string.Format("{0:0.0}", r);
                final = final.Replace(",", ".");
                Console.WriteLine(final);
            }
        }
    }
}
