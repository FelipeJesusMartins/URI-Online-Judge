using System;
using System.Globalization;

namespace _1098_Sequencia_IJ_4_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            double j, valor;
            int temp, temp2;
            valor = 0;
            temp = 0;
            temp2 = 0;

            j = 1;

            for (double i = 0; i < 2.0; j++)
            {
                if (temp2 == 0)
                {
                    Console.WriteLine("I=" + i.ToString("F0", CultureInfo.InvariantCulture) + " J=" + j.ToString("F0", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("I=" + i.ToString("F1", CultureInfo.InvariantCulture) + " J=" + j.ToString("F1", CultureInfo.InvariantCulture));
                }

                temp++;

                if (temp == 3)
                {

                    i += 0.2;

                    valor += 0.2;

                    j = valor;

                    temp = 0;

                    temp2++;
                }
                if (temp2 == 5)

                    temp2 = 0;
            }

            Console.ReadKey();
        }
    }
}
