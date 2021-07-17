using System;

namespace _1177_Preenchimento_de_Vetor_II_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] vetor = new int[1000];
            int n = int.Parse(Console.ReadLine());

            for (int i = 0, a = 0; i < 1000; i++)
            {
                Console.WriteLine($"N[{i}] = {a}");
                //vetor[i] = a;
                a++;
                if(a == n)
                    a = 0;
            }
            /*
             O desafio pede para preencher um vetor porém não é necessário preencher o vetor para obter a output esperada   
             */
        }
    }
}
