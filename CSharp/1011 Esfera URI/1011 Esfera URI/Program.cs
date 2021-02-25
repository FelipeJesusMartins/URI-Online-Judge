using System;
using System.Globalization;

namespace _1011_Esfera_URI
{
    class Program
    {
        static void Main(string[] args)
        {

            double pi, r, form;
            pi = 3.14159;

            r = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            form = 4.0 / 3.0 * pi * Math.Pow(r, 3);

            Console.WriteLine("VOLUME = " + form.ToString("F3",CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
