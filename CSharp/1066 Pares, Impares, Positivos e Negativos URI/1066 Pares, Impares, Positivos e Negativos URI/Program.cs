using System;

namespace _1066_Pares__Impares__Positivos_e_Negativos_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5, par, impar, positivo, negativo;

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());
            n5 = int.Parse(Console.ReadLine());

            par = 0;
            impar = 0;
            positivo = 0;
            negativo = 0;

            // PARES E IMPARES

            if (n1 % 2 == 0)
            {
                par += 1;
            }
            else
            {
                impar += 1;
            }
            if (n2 % 2 == 0)
            {
                par += 1;
            }
            else
            {
                impar += 1;
            }
            if (n3 % 2 == 0)
            {
                par += 1;
            }
            else
            {
                impar += 1;
            }
            if (n4 % 2 == 0)
            {
                par += 1;
            }
            else
            {
                impar += 1;
            }
            if (n5 % 2 == 0)
            {
                par += 1;
            }
            else
            {
                impar += 1;
            }

            //POSITIVOS E NEGATIVOS

            if (n1 > 0)
            {
                positivo += 1;
            }
            else if (n1 < 0)
            {
                negativo += 1;
            }
            if (n2 > 0)
            {
                positivo += 1;
            }
            else if (n2 < 0)
            {
                negativo += 1;
            }
            if (n3 > 0)
            {
                positivo += 1;
            }
            else if (n3 < 0)
            {
                negativo += 1;
            }
            if (n4 > 0)
            {
                positivo += 1;
            }
            else if (n4 < 0)
            {
                negativo += 1;
            }
            if (n5 > 0)
            {
                positivo += 1;
            }
            else if (n5 < 0)
            {
                negativo += 1;
            }

            Console.WriteLine(par + " valor(es) par(es)");
            Console.WriteLine(impar + " valor(es) impar(es)");
            Console.WriteLine(positivo + " valor(es) positivo(s)");
            Console.WriteLine(negativo + " valor(es) negativo(s)");

            Console.ReadKey();
        }
    }
}