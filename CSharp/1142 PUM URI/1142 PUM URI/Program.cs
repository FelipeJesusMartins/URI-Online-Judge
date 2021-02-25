using System;

namespace _1142_PUM_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int cont = 1;

            for (int i = 0; i < x; i++)
            {
                Console.Write(cont+" ");
                Console.Write(cont + 1 + " ");
                Console.Write(cont + 2 + " ");
                Console.WriteLine("PUM");
                cont += 4;
            }
            Console.ReadKey();
        }
    }
}
