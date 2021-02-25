using System;

namespace _1115_Quadrante_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema cartesiano.
            Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo menos uma de duas
            coordenadas for NULA (nesta situação sem escrever mensagem alguma).

            1° quadrante: ambas as coordenadas são positivas: x≥0 e y≥0;
            2° quadrante: a coordenada x é negativa e a y positiva: x≤0 e y≥0;
            3° quadrante: ambas as coordenadas são negativas: x≤0 e y≤0;
            4° quadrante: apenas a coordenada y é negativa: x≥0 e y≤0
             */

            int x, y;

            string[] vet = Console.ReadLine().Split(' ');

            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            while (x != 0 || y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                }

                vet = Console.ReadLine().Split(' ');

                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
            }
            Console.ReadKey();
        }
    }
}
