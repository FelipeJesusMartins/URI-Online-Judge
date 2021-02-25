using System;

namespace _1144_Sequencia_Logica_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                int segundo = i * i;
                int terceiro = i * i * i;
                Console.WriteLine(i + " " + segundo + " " + terceiro);
                Console.WriteLine(i + " " + (segundo + 1) + " " + (terceiro + 1));
            }
            Console.ReadKey();
        }
    }
}
