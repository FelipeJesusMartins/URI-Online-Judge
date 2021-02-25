using System;
using System.Globalization;

namespace _1156_Sequencia_S_II_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            double den = 1.0, s = 0.0;
            for (num = 1; num <= 39; num += 2)
            {
                s += num / den;
                den *= 2.0;
            }
            Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
