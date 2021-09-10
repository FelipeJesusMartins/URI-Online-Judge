using System;
using System.Globalization;

namespace _1021_Notas_e_Moedas_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            Double n;
            int resto;

            n = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            resto = (int)(n * 100.0 + 0.5);

            Console.WriteLine("NOTAS:");

            Console.WriteLine($"{resto / (100*100)} nota(s) de R$ 100.00");
            resto %= (100 * 100);
            Console.WriteLine($"{resto / (100*50)} nota(s) de R$ 50.00");
            resto %= (50 * 100);
            Console.WriteLine($"{resto / (100*20)} nota(s) de R$ 20.00");
            resto %= (20 * 100);
            Console.WriteLine($"{resto / (100*10)} nota(s) de R$ 10.00");
            resto %= (10 * 100);
            Console.WriteLine($"{resto / (100*5)} nota(s) de R$ 5.00");
            resto %= (5 * 100);
            Console.WriteLine($"{resto / (100*2)} nota(s) de R$ 2.00");
            resto %= (2 * 100);

            Console.WriteLine("MOEDAS:");

            Console.WriteLine($"{resto / 100} moeda(s) de R$ 1.00");
            resto %= 100;
            Console.WriteLine($"{resto / 50} moeda(s) de R$ 0.50");
            resto %= 50;
            Console.WriteLine($"{resto / 25} moeda(s) de R$ 0.25");
            resto %= 25;
            Console.WriteLine($"{resto / 10} moeda(s) de R$ 0.10");
            resto %= 10;
            Console.WriteLine($"{resto / 5} moeda(s) de R$ 0.05");
            resto %= 5;
            Console.WriteLine($"{resto} moeda(s) de R$ 0.01");
        }

    }
}