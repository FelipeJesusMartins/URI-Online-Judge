using System;

namespace _1002_Area_do_circulo_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"A={(3.14159 * Math.Pow(double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture), 2)).ToString("F4", System.Globalization.CultureInfo.InvariantCulture)}");
        }
    }
}
