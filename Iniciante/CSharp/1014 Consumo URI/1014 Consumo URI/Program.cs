using System;
using System.Globalization;

namespace _1014_Consumo_URI
{
    class Program
    {
        static void Main(string[] args)
        {

            double x, y, z;

            x = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            y = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            z = x / y;

            Console.WriteLine(z.ToString("F3", CultureInfo.InvariantCulture) + " km/l");

            Console.ReadKey();
        }
    }
}
