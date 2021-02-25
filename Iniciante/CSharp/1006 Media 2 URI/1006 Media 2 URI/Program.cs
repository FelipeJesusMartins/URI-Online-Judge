using System;
using System.Globalization;

namespace _1006_Media_2_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, media, mp1, mp2, mp3;
            mp1 = 2;
            mp2 = 3;
            mp3 = 5;

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = ((a * mp1) + (b * mp2) + (c * mp3)) / (mp1 + mp2 + mp3);

            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
