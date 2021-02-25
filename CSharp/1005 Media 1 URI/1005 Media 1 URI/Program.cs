using System;
using System.Globalization;

namespace _1005_Media_1_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, media, mp1, mp2;
            mp1 = 3.5;
            mp2 = 7.5;

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = ((a * mp1) + (b * mp2)) / 11;

            Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
