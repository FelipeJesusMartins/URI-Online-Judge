using System;

namespace _1078_Tabuada_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            for(int i = 1;i <= 10; i++)
            {
                Console.WriteLine(i + " x " + x + " = " + (x * i));
            }
            Console.ReadKey();
        }
    }
}
