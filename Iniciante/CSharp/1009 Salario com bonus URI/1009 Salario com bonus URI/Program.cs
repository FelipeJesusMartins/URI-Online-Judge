using System;
using System.Globalization;

namespace _1009_Salario_com_bonus_URI
{
    class Program
    {
        static void Main(string[] args)
        {

            String nomeVendedor;
            double salarioFixo, vendasEfetuadas, bonus, salarioFinal;

            nomeVendedor = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            vendasEfetuadas = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            bonus = ((vendasEfetuadas / 100) * 15);
            salarioFinal = (salarioFixo + bonus);

            Console.WriteLine("TOTAL = R$ " + salarioFinal.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
