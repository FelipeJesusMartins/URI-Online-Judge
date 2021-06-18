using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1164_Numero_Perfeito_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialValue = int.Parse(Console.ReadLine());

            if (initialValue >= 1 && initialValue <= 20)
            {
                for (int counter = 0; counter < initialValue; counter++)
                {
                    int finalValue = 0;
                    int y = 0;

                    int x = int.Parse(Console.ReadLine());

                    for (y = 1; y < x; y++)
                    {
                        if (x % y == 0)
                        {
                            finalValue += y;
                        }
                    }
                    if (finalValue == x)
                    {
                        Console.WriteLine($"{x} eh perfeito");
                    }
                    else
                    {
                        Console.WriteLine($"{x} nao eh perfeito");
                    }
                }
            }
            else
            {
                Environment.Exit(1);
            }
        }
    }
}
