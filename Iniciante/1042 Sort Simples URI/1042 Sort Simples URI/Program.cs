using System;

namespace _1042_Sort_Simples_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            string[] valores = Console.ReadLine().Split(' ');

            x = int.Parse(valores[0]);
            y = int.Parse(valores[1]);
            z = int.Parse(valores[2]);


            if (x < y && x < z && y < z)
            {
                Console.WriteLine(x);
                Console.WriteLine(y);
                Console.WriteLine(z);
            }
            else if (x < y && x < z && z < y)
            {
                Console.WriteLine(x);
                Console.WriteLine(z);
                Console.WriteLine(y);
            }
            else if (y < x && y < z && x < z)
            {
                Console.WriteLine(y);
                Console.WriteLine(x);
                Console.WriteLine(z);
            }
            else if (y < x && y < z && z < x)
            {
                Console.WriteLine(y);
                Console.WriteLine(z);
                Console.WriteLine(x);
            }
            else if (z < x && z < y && x < y)
            {
                Console.WriteLine(z);
                Console.WriteLine(x);
                Console.WriteLine(y);
            }
            else if (z < y && z < x && y < x)
            {
                Console.WriteLine(z);
                Console.WriteLine(y);
                Console.WriteLine(x);
            }

            Console.WriteLine();

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.ReadKey();
        }
    }
}