using System;

namespace _1046_Tempo_de_jogo_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo,
             sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

            Entrada
            A entrada contém dois valores inteiros representando a hora de início e a hora de fim do jogo.
             */
            int x, y, duracao;
            string[] vet = Console.ReadLine().Split(' ');

            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            if (x < y)
            {
                duracao = y - x;
            }
            else
            {
                duracao = 24 - x + y;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");

            Console.ReadKey();
        }
    }
}
