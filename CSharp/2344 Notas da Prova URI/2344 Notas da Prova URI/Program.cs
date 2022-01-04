using System;

namespace _2344_Notas_da_Prova_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte x = sbyte.Parse(Console.ReadLine());
            if (x > 0 && x < 36) { Console.WriteLine("D"); }
            else if (x > 35 && x < 61) { Console.WriteLine("C"); }
            else if (x > 60 && x < 86) { Console.WriteLine("B"); }
            else if (x > 85 && x < 101) { Console.WriteLine("A"); }
            else { Console.WriteLine("E"); }
        }
    }
}
