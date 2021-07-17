using System;

namespace _1176_Fibonacci_em_Vetor_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases;
            ulong[] fib = new ulong[100];

            for (int i = 2; i < 100; i++)
            {
                fib[0] = 0;
                fib[1] = 1;

                fib[i] = fib[i - 1] + fib[i - 2];
            }
            cases = int.Parse(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                int input = int.Parse(Console.ReadLine());
                Console.Write($"Fib({input}) = {fib[input]}\n");
            }
        }
    }
}
