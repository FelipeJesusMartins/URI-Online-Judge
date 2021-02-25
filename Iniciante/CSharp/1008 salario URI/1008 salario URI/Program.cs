using System;
using System.Globalization;

namespace _1008_salario_URI
{
    class Program
    {
        static void Main(string[] args)
        {

            int Nfunc, Nhoras;
            double Vhora, salario;
            
            Nfunc = int.Parse(Console.ReadLine());
            Nhoras = int.Parse(Console.ReadLine());
            Vhora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            salario = Vhora * Nhoras;

            Console.WriteLine("NUMBER = " + Nfunc);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
