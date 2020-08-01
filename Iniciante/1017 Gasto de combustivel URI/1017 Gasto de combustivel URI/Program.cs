using System;
using System.Globalization;

namespace _1017_Gasto_de_combustivel_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, m, r;
            m = 12;
            x = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            y = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            r = (y / m) * x;
            Console.WriteLine(r.ToString("F3",CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
