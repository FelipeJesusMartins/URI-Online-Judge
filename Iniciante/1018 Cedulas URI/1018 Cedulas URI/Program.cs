using System;

namespace _1018_Cedulas_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, x, resto, nota;

            N = int.Parse(Console.ReadLine());
            Console.WriteLine(N);

            resto = N;

            nota = 100;
            x = resto / nota;
            Console.WriteLine(x + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 50;
            x = resto / nota;
            Console.WriteLine(x + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 20;
            x = resto / nota;
            Console.WriteLine(x + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 10;
            x = resto / nota;
            Console.WriteLine(x + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 5;
            x = resto / nota;
            Console.WriteLine(x + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 2;
            x = resto / nota;
            Console.WriteLine(x + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            Console.WriteLine(resto + " nota(s) de R$ 1,00");
            Console.ReadKey();
        }
    }
}
