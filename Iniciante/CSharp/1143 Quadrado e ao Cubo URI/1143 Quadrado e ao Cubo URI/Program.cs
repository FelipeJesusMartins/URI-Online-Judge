using System;

namespace _1143_Quadrado_e_ao_Cubo_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                Console.Write(i+" ");
                Console.Write(i * i + " ");
                Console.WriteLine(i * i * i);
            }
            Console.ReadKey();
        }
    }
}
