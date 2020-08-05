using System;
using System.Globalization;

namespace _1155_Sequencia_S_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = 0;
            for (int i = 1; i <= 100; i++)
            {
                soma += 1.0 / i;
            }
            Console.WriteLine(soma.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
