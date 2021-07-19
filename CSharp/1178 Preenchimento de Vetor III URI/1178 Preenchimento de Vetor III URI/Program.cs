using System;
using System.Globalization;

namespace _1178_Preenchimento_de_Vetor_III_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine()) ;

            for (int i = 0; i < 100; i++)
            {
                decimal.Round(a, 4, MidpointRounding.ToEven);
                Console.WriteLine($"N[{i}] = {Math.Round(a,4).ToString(CultureInfo.InvariantCulture)}");
                a /= 2;

                /*o programa apenas reconhece quando o input do numero é feito com o uso da virgula como separador
                 * por exemplo 200,0000 dá certo porém 200.0000 já não funciona
                */
            }
        }
    }
}
