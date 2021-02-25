using System;

namespace _1096_Sequencia_IJ_2_URI
{
    class Program
    {
        static void Main(string[] args)
        {

            int j;
            j = 7;

            for (int i = 1; i <= 9; i += 2)
            {
                j = 7;
                Console.WriteLine("I=" + i + " J=" + j);
                j -= 1;
                Console.WriteLine("I=" + i + " J=" + j);
                j -= 1;
                Console.WriteLine("I=" + i + " J=" + j);
                j -= 1;

            }
            Console.ReadKey();
        }
    }
}