using System;
using System.Globalization;

namespace _1060_Numeros_positivos_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, n5, n6;
            int nf = 6;

            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (n1 < 0)
            {
                nf -= 1;
            }
            if (n2 < 0)
            {
                nf -= 1;
            }
            if (n3 < 0)
            {
                nf -= 1;
            }
            if (n4 < 0)
            {
                nf -= 1;
            }
            if (n5 < 0)
            {
                nf -= 1;
            }
            if (n6 < 0)
            {
                nf -= 1;
            }
            Console.WriteLine(nf + " valores positivos");
            Console.ReadKey();
        }
    }
}
