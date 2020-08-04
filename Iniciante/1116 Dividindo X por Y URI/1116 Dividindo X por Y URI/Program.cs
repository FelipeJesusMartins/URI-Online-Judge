using System;
using System.Globalization;

namespace _1116_Dividindo_X_por_Y_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                double x = double.Parse(vet[0]);
                double y = double.Parse(vet[1]);

                double resultado = x / y;

                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
                }
            }

            Console.ReadKey();
        }
    }
}
