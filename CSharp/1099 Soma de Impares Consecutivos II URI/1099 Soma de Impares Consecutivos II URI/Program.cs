using System;

namespace _1099_Soma_de_Impares_Consecutivos_II_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int num1, num2, max, min, soma;
            min = 0;
            max = 0;


            for (int i = 0; i < x; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                num1 = int.Parse(vet[0]);
                num2 = int.Parse(vet[1]);

                if (num1 > num2)
                {
                    max = num1;
                    min = num2;
                }
                else
                {
                    min = num1;
                    max = num2;
                }

                soma = 0;
                for (int z = min + 1; z < max; z++)
                {
                    if (z % 2 != 0)
                    {
                        soma += z;
                    }
                }
                Console.WriteLine(soma);
            }
            Console.ReadKey();
        }
    }
}
