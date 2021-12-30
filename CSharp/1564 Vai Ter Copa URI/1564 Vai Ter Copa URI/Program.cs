using System;

namespace _1564_Vai_Ter_Copa_URI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x;
            while (!string.IsNullOrEmpty(x = Console.ReadLine()))
            {
                Console.WriteLine((int.Parse(x) == 0) ? "vai ter copa!" : "vai ter duas!");
            }
        }
    }
}