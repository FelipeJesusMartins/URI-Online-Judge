using System;

namespace _1002_Area_do_circulo_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi, area, raio;
            pi = 3.14159;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = pi * Math.Pow(raio, 2);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
