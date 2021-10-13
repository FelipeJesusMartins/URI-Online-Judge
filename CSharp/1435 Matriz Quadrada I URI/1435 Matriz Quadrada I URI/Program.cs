using System;

namespace _1435_Matriz_Quadrada_I_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            //while(N == 1)
            //{
                int
                    a,
                    b,
                    c,
                    g,
                    h,
                    i,
                    j = 1,
                    p = 0,
                    q = 0,
                    r = 0;


                if (N == 0) Environment.Exit(0);

                int[,] arr = new int[N, N];

                i = N;
                if (N % 2 == 0)
                {
                    r = N / 2;
                }
                else if (N % 2 == 1)
                {
                    r = (N / 2) + 1;
                }
                for (c = 1; c <= r; c++)
                {
                    for (a = p; a < i; a++)
                    {
                        for (b = q; b < i; b++)
                        {
                            arr[a, b] = j;
                        }
                    }
                    j++;
                    p++;
                    q++;
                    i--;
                }
                for (g = 0; g < N; g++)
                {
                    for (h = 0; h < N; h++)
                    {
                        if (h == 0)
                        {
                            Console.Write($"{arr[g, h]}");
                        }
                        else
                        {
                            Console.Write($"{arr[g, h]}");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
            //}
            // N = int.Parse(Console.ReadLine());
        }
    }
}