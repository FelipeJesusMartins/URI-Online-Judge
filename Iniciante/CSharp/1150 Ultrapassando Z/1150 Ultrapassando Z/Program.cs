using System;

namespace _1150_Ultrapassando_Z
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            while (z <= x)
            {
                z = int.Parse(Console.ReadLine());
            }

            int cont = 1;
            int soma = x;
            do
            {
                x += 1;
                soma += x;
                cont += 1;
            }
            while (soma <= z);

            Console.WriteLine(cont);
            Console.ReadKey();
        }
    }
}
