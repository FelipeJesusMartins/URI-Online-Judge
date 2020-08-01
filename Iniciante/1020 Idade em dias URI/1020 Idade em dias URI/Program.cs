using System;

namespace _1020_Idade_em_dias_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, ano, mes, dia, resto;

            idade = int.Parse(Console.ReadLine());

            resto = idade;

            ano = resto / 365;
            Console.WriteLine(ano + " ano(s)");
            resto = resto % 365;

            mes = resto / 30;
            Console.WriteLine(mes + " mes(es)");
            resto = resto % 30;

            dia = resto;
            Console.WriteLine(dia + " dia(s)");

            Console.ReadKey();
        }
    }
}
