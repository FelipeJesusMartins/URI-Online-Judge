using System;

namespace _1073_Quadrado_de_Pares_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i<=n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + "^2 = " + Math.Pow(i, 2));
                }
            }
            Console.ReadKey();
        }
    }
}
