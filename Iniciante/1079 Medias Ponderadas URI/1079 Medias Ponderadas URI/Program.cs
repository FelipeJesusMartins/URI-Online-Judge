using System;
using System.Globalization;

namespace _1079_Medias_Ponderadas_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double x, y, z, media;
            x = 0;
            y = 0;
            z = 0;

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                x = double.Parse(vet[0], CultureInfo.InvariantCulture);
                y = double.Parse(vet[1], CultureInfo.InvariantCulture);
                z = double.Parse(vet[2], CultureInfo.InvariantCulture);
                media = ((x * 2.0) + (y * 3.0) + (z * 5.0)) / 10.0;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
