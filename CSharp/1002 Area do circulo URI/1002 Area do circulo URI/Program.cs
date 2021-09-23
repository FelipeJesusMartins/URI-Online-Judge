using System;
using System.Globalization;

namespace _1002_Area_do_circulo_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"A={(3.14159 * (raio * raio)).ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}
