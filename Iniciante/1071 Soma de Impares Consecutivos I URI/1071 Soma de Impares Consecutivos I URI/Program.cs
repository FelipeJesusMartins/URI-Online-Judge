using System;

namespace _1071_Soma_de_Impares_Consecutivos_I_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, max, min, soma;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                max = x;
                min = y;
            }
            else
            {
                max = y;
                min = x;
            }

            soma = 0;
            for (int i = min + 1; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine(soma);
            Console.ReadKey();
        }
    }
}
