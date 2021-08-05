using System;

namespace _1435_Matriz_Quadrada_I_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;
            string final = "";

            do
            {
                b = int.Parse(Console.ReadLine());
                int[,] arr = new int[b, b];
                for (int i = 0; i < b; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        arr[i, j] = b;
                    }
                }
                for (int i = 0; i < b; i++)
                {
                    for (int j = 0; j < b; j++)
                    {
                        final += $" {arr[i, j]}";
                    }
                    final += "\n";
                }
                Console.WriteLine(final);
                final = string.Empty;
            }

            while (b > 0);
        }

    }
}