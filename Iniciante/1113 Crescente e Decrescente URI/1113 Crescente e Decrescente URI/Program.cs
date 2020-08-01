﻿using System;

namespace _1113_Crescente_e_Decrescente_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Leia uma quantidade indeterminada de duplas de valores inteiros X e Y. Escreva para cada X e Y
            uma mensagem que indique se estes valores foram digitados em ordem crescente ou decrescente.

            Entrada
            A entrada contém vários casos de teste. Cada caso contém dois valores inteiros X e Y.
            A leitura deve ser encerrada ao ser fornecido valores iguais para X e Y.

            Saída
            Para cada caso de teste imprima “Crescente”, caso os valores tenham sido digitados na ordem crescente,
            caso contrário imprima a mensagem “Decrescente”.
             */

            int x, y;

            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            while (x != y)
            {
                if (x < y)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    Console.WriteLine("Decrescente");
                }
                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

            }
            Console.ReadKey();
        }
    }
}
