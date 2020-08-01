using System;
using System.Globalization;

namespace _1036_Formula_de_bhaskara_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z, delta, r1, r2;

            string[] vet = Console.ReadLine().Split(' ');

            x = double.Parse(vet [0], CultureInfo.InvariantCulture);
            y = double.Parse(vet[1], CultureInfo.InvariantCulture);
            z = double.Parse(vet[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(y, 2) - 4 * x * z;

            if (x == 0 || delta < 0.0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                r1 = (-y + Math.Sqrt(delta)) / (2.0 * x);
                r2 = (-y - Math.Sqrt(delta)) / (2.0 * x);
                Console.WriteLine("R1 = " + r1.ToString("F5",CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + r2.ToString("F5",CultureInfo.InvariantCulture));
            }

            Console.ReadKey();
        }
    }
}
