﻿using System;

namespace _1007_Diferenca_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, dif;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            dif = (a*b)-(c*d);

            Console.WriteLine("DIFERENCA = " + dif);
            Console.ReadKey();
        }
    }
}
