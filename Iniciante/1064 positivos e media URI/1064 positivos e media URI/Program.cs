using System;
using System.Globalization;

namespace _1064_positivos_e_media_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, n5, n6, nf, media;

            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            nf = 0.0;
            media = 0.0;

            if (n1 > 0.0)
            {
                nf += 1;
                media += n1;
            }
            if (n2 > 0.0)
            {
                nf += 1;
                media += n2;
            }
            if (n3 > 0.0)
            {
                nf += 1;
                media += n3;
            }
            if (n4 > 0.0)
            {
                nf += 1;
                media += n4;
            }
            if (n5 > 0.0)
            {
                nf += 1;
                media += n5;
            }
            if (n6 > 0.0)
            {
                nf += 1;
                media += n6;
            }

            media = media / nf;

            Console.WriteLine(nf + " valores positivos");
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
