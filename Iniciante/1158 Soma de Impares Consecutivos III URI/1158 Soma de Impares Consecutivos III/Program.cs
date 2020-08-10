using System;

namespace _1158_Soma_de_Impares_Consecutivos_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                int x = int.Parse(valores[0]);
                int y = int.Parse(valores[1]);
                int soma = 0;

                for (int p = 0; p < y;x++)
                {
                    if (x % 2 != 0)
                    {
                        soma += x;
                        p++;
                    }
                }
                Console.WriteLine(soma);
            }
            Console.ReadKey();
        }
    }
}
