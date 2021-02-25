using System;

namespace _1072_intervalo_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            int contIN = 0;
            int contOUT = 0;

            for (int i = 0; i < x; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n >= 10 && n <= 20)
                {
                    contIN += 1;
                }
                else
                {
                    contOUT += 1;
                }
            }

            Console.WriteLine(contIN + " in");
            Console.WriteLine(contOUT + " out");
            Console.ReadKey();

        }
    }
}
