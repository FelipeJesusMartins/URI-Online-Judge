using System;

namespace _1095_Sequencia_IJ_1_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int j;
            j = 60;

            for (int i = 1;j >= 0;i+=3)
            {
                Console.WriteLine("I=" + i + " J=" + j);
                j -= 5;
            }
            Console.ReadKey();
        }
    }
}
