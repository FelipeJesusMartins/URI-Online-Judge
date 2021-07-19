using System;

namespace _1179_Preenchimento_de_Vetor_IV_URI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] even = new int[5];
            int[] odd = new int[5];
            int[] input = new int[15];
            int par = 0;
            int impar = 0;


            for (int i = 0; i < 15; i++)
            {
                input[i] = int.Parse(Console.ReadLine());

                if (input[i] % 2 == 0)
                {
                    even[par] = input[i];
                    par++;
                }
                else
                {
                    odd[impar] = input[i];
                    impar++;
                }
                if (par == even.Length)
                {
                    for (int a = 0; a < even.Length; a++)
                    {
                        Console.WriteLine($"par[{a}] = {even[a]}");
                    }
                    Array.Clear(even, 0, even.Length);
                    par = 0;
                }
                else if (impar == odd.Length)
                {
                    for (int b = 0; b < odd.Length; b++)
                    {
                        Console.WriteLine($"impar[{b}] = {odd[b]}");
                    }
                    Array.Clear(odd, 0, odd.Length);
                    impar = 0;
                }
            }

            for (int b = 0; b < impar; b++)
            {
                Console.WriteLine($"impar[{b}] = {odd[b]}");
            }
            for (int a = 0; a < par; a++)
            {
                Console.WriteLine($"par[{a}] = {even[a]}");
            }
        }
    }
}