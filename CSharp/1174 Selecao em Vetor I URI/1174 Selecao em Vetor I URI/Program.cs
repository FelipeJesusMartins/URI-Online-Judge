using System;
using System.Globalization;

namespace _1174_Selecao_em_Vetor_I_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[100];
            for (int i = 0; i < 100; i++)
            {
                numbers[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            for (int i = 0; i < 100; i++)
            {
                if (numbers[i] <= 10.0)
                {
                    Console.Write($"A[{i}] = {numbers[i].ToString("N1",CultureInfo.InvariantCulture).Replace(",","")}\n");
                }
            }
        }
    }
}
