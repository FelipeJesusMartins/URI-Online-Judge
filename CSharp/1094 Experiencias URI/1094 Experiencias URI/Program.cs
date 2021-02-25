using System;

namespace _1094_Experiencias_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, quantia, coelho, rato, sapo, total;
            char tipo;

            coelho = 0;
            rato = 0;
            sapo = 0;
            total = 0;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                quantia = int.Parse(vet[0]);
                tipo = char.Parse(vet[1]);

                if (tipo == 'C')
                {
                    coelho += quantia;
                }
                else if (tipo == 'R')
                {
                    rato += quantia;
                }
                else
                {
                    sapo += quantia;
                }
                total += quantia;
            }

            double porcentagemCoelhos = (double)coelho / total * 100.0;
            double porcentagemRatos = (double)rato / total * 100.0;
            double porcentagemSapos = (double)sapo / total * 100.0;

            Console.WriteLine("Total: " + total + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelho);
            Console.WriteLine("Total de ratos: " + rato);
            Console.WriteLine("Total de sapos: " + sapo);
            Console.WriteLine("Percentual de coelhos: " + porcentagemCoelhos.ToString("F2") + " %");
            Console.WriteLine("Percentual de ratos: " + porcentagemRatos.ToString("F2") + " %");
            Console.WriteLine("Percentual de sapos: " + porcentagemSapos.ToString("F2") + " %");

            Console.ReadKey();
        }
    }
}
