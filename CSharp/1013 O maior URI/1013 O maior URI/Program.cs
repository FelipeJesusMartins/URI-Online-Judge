using System;

namespace _1013_O_maior_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            string valores = Console.ReadLine();
            string [] vet = valores.Split(' ');

            x = int.Parse(vet [0]);
            y = int.Parse(vet[1]);
            z = int.Parse(vet[2]);

            if (x > y)
            {
                if (x > z) Console.WriteLine(x + " eh o maior ");
                else Console.WriteLine(z + " eh o maior ");
            }
            else
            {
                if (y > z) Console.WriteLine(y +" eh o maior");
                else Console.WriteLine(z + " eh o maior");
            }

            /* Forma do professor
                 using System;

                namespace uri1013 {
                 class Program {
                    static void Main(string[] args) {

                     int x, y, z, maiorXY, maior;

                    string[] valores = Console.ReadLine().Split(' ');
                    x = int.Parse(valores[0]);
                    y = int.Parse(valores[1]);
                    z = int.Parse(valores[2]);

                    maiorXY = (x + y + Math.Abs(x - y)) / 2;

                    maior = (maiorXY + z + Math.Abs(maiorXY - z)) / 2;

                    Console.WriteLine(maior + " eh o maior");
                        }
                    }
                }
             */
        }
    }
}
