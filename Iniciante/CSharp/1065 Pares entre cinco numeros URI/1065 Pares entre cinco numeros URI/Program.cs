using System;

namespace _1065_Pares_entre_cinco_numeros_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Faça um programa que leia 5 valores inteiros. Conte quantos destes valores digitados são pares e mostre esta informação.
             */

            int n1, n2, n3, n4, n5, nf;

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());
            n5 = int.Parse(Console.ReadLine());

            nf = 0;

            if (n1 % 2 == 0)
            {
                nf += 1;
            }
            if (n2 % 2 == 0)
            {
                nf += 1;
            }
            if (n3 % 2 == 0)
            {
                nf += 1;
            }
            if (n4 % 2 == 0)
            {
                nf += 1;
            }
            if (n5 % 2 == 0)
            {
                nf += 1;
            }

            Console.WriteLine(nf + " valores pares");
            Console.ReadKey();
        }
    }
}
