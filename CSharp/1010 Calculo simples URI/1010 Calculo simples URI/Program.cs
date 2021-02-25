using System;
using System.Globalization;

namespace _1010_Calculo_simples_URI
{
    class Program
    {
        static void Main(string[] args)
        {

            int Cp1, Cp2, Np1, Np2;
            double Vp1, Vp2, Vf1, Vf2, VF;
            String V1, V2;

            V1 = Console.ReadLine();
            String[] vet1 = V1.Split(' ');
            V2 = Console.ReadLine();
            String[] vet2 = V2.Split(' ');

            Cp1 = int.Parse(vet1[0]);
            Np1 = int.Parse(vet1[1]);
            Vp1 = double.Parse(vet1[2],CultureInfo.InvariantCulture);
            Cp2 = int.Parse(vet2[0]);
            Np2 = int.Parse(vet2[1]);
            Vp2 = double.Parse(vet2[2],CultureInfo.InvariantCulture);

            Vf1 = (Np1 * Vp1);
            Vf2 = (Np2 * Vp2);
            VF = (Vf1 + Vf2);

            Console.WriteLine("VALOR A PAGAR: R$ " + VF.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
