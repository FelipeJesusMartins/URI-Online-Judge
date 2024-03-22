using System;

class Program
{
    static void Main(string[] args)
    {
        int length;
        do
        {
            length = int.Parse(Console.ReadLine());

            if (length == 0)
                break;

            Creatematrix(length, 0);
            Console.WriteLine();

        } while (length != 0);
    }

    static void Creatematrix(int tamanho, int n)
    {
        if (n >= tamanho) return;
        string val = "";
        for (int j = 0; j < tamanho; j++)
            val += $"{(Math.Min(Math.Min(n, j), Math.Min(tamanho - 1 - n, tamanho - 1 - j)) + 1),4}";

        Console.WriteLine("  " + val.Trim());

        Creatematrix(tamanho, n+1);
    }
}
