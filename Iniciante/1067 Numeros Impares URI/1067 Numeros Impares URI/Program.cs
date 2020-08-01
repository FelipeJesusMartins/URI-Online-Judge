using System;

namespace _1067_Numeros_Impares_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, cont;
            x = int.Parse(Console.ReadLine());
            cont = 1;

            while (cont != x)
            {
                Console.WriteLine(cont);
                cont += 2;
            }
            if (x % 2 == 0.5)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
