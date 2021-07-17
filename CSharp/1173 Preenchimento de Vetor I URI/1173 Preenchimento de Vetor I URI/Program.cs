using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1173_Preenchimento_de_Vetor_I_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[10];

            values[0] = int.Parse(Console.ReadLine());
            Console.WriteLine($"N[0] = {values[0]}");

            for (int i = 1; i < 10; i++)
            {
                values [i] = values[i-1] * 2;
                Console.WriteLine($"N[{i}] = {values[i]}");
            }
        }
    }
}