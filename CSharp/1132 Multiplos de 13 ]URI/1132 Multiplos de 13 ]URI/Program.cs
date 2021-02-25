
using System;

namespace _1132_Multiplos_de_13__URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, soma,min,max;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            soma = 0;

            if(x > y)
            {
                max = x;
                min = y;
            }
            else
            {
                max = y;
                min = x;
            }

            for (int i = min;i <= max; i++)
            {
                if (i % 13 != 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine(soma);
            Console.ReadKey();
        }
    }
}
