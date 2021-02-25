using System;
using System.Globalization;

namespace _1015_Distancia_entre_dois_pontos_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, resultado;
            String valores1, valores2;
            String[] vet1;
            String[] vet2;

            valores1 = Console.ReadLine();
            valores2 = Console.ReadLine();

            vet1 = valores1.Split(' ');
            x1 = double.Parse(vet1[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(vet1[1], CultureInfo.InvariantCulture);

            vet2 = valores2.Split(' ');
            x2 = double.Parse(vet2[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(vet2[1], CultureInfo.InvariantCulture);

            resultado = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));
            Console.WriteLine(resultado.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
