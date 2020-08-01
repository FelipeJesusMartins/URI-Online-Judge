using System;
using System.Security.Cryptography.X509Certificates;

namespace _1059_Numeros_Pares_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (x != 100)
            {
                x = x + 2;
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
