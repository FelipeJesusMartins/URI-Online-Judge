using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1175_Troca_em_Vetor_I_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            for (int i = 19; i >= 0; i--)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"N[{i}] = {array[i]}");
            }
        }
    }
}
