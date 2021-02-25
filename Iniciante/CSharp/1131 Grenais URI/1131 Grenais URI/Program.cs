using System;

namespace _1131_Grenais_URI
{
    class Program
    {
        static void Main(string[] args)
        {

            int inter, gremio, grenal, contgrenal, continter, contgremio, empate;

            grenal = 1;
            contgrenal = 1;
            continter = 0;
            contgremio = 0;
            empate = 0;

            while (grenal == 1)
            {
                string[] vet = Console.ReadLine().Split(' ');

                inter = int.Parse(vet[0]);
                gremio = int.Parse(vet[1]);

                if (inter > gremio)
                {
                    continter += 1;
                }
                else if (gremio > inter)
                {
                    contgremio += 1;
                }
                else if (gremio == inter)
                {
                    empate += 1;
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                grenal = int.Parse(Console.ReadLine());

                if (grenal == 1)
                {
                    contgrenal += 1;
                }
            }

            Console.WriteLine(contgrenal + " grenais");
            Console.WriteLine("Inter:" + continter);
            Console.WriteLine("Gremio:" + contgremio);
            Console.WriteLine("Empates:" + empate);

            if (continter > contgremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (contgremio > continter)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor");
            }

            Console.ReadKey();

        }
    }
}