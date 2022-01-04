using System;

namespace _3342_Keanu_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"{(x * x) - ((x * x) / 2)} casas brancas e {(x * x) / 2} casas pretas");
        }
    }
}
