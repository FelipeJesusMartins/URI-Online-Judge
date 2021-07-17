using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1172_Substituição_em_Vetor_I_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[10];
            for (int i = 0; i < 10; i++)
            {
                values[i] = int.Parse(Console.ReadLine());
                if (values[i] <= 0)
                    values[i] = 1;
            }
            for(int i = 0;i<10;i++)
            {
                Console.WriteLine($"X[{i}] = {values[i]}");
            }
        }
    }
}
