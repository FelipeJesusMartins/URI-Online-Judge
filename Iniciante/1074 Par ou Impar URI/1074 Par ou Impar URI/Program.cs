using System;

namespace _1074_Par_ou_Impar_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                int y = int.Parse(Console.ReadLine());
                if (y % 2 == 0 && y != 0)
                {
                    Console.Write("EVEN");
                }
                else if(y % 2 != 0 && y != 0)
                {
                    Console.Write("ODD");
                }
                if (y > 0)
                {
                    Console.WriteLine(" " +
                        "POSITIVE");
                }
                else if (y < 0)
                {
                    Console.WriteLine(" NEGATIVE");
                }
                if (y == 0)
                {
                    Console.WriteLine("NULL");
                }
            }
            Console.ReadKey();
        }
    }
}
