using System;
using System.Globalization;

namespace _1048_Aumento_de_salario_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, porcentagem, reajuste;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 400.00 && salario >= 0.00)
            {
                porcentagem = 15;
                reajuste = salario / 100 * porcentagem;
                salario += salario / 100 * porcentagem;
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + porcentagem + " %");
            }
            else if (salario > 400.00 && salario <= 800.00)
            {
                porcentagem = 12;
                reajuste = salario / 100 * porcentagem;
                salario += salario / 100 * porcentagem;
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + porcentagem + " %");
            }
            else if (salario > 800.00 && salario <= 1200.00)
            {
                porcentagem = 10;
                reajuste = salario / 100 * porcentagem;
                salario += salario / 100 * porcentagem;
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + porcentagem + " %");
            }
            else if (salario > 1200.00 && salario <= 2000.00)
            {
                porcentagem = 7;
                reajuste = salario / 100 * porcentagem;
                salario += salario / 100 * porcentagem;
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + porcentagem + " %");
            }
            else if (salario > 2000.00)
            {
                porcentagem = 4;
                reajuste = salario / 100 * porcentagem;
                salario += salario / 100 * porcentagem;
                Console.WriteLine("Novo salario: " + salario.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Em percentual: " + porcentagem + " %");
            }


            Console.ReadKey();
        }
    }
}
