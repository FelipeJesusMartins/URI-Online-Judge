using System;

namespace _2582_System_of_a_Download
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            for (byte i = 0; i < n; i++)
            {
                string[] nums = Console.ReadLine().Split(' ');

                byte a = (byte)(byte.Parse(nums[0]) + byte.Parse(nums[1]));

                if (a == 0) { Console.WriteLine("PROXYCITY"); }
                else if (a == 1) { Console.WriteLine("P.Y.N.G."); }
                else if (a == 2) { Console.WriteLine("DNSUEY!"); }
                else if (a == 3) { Console.WriteLine("SERVERS"); }
                else if (a == 4) { Console.WriteLine("HOST!"); }
                else if (a == 5) { Console.WriteLine("CRIPTONIZE"); }
                else if (a == 6) { Console.WriteLine("OFFLINE DAY"); }
                else if (a == 7) { Console.WriteLine("SALT"); }
                else if (a == 8) { Console.WriteLine("ANSWER!"); }
                else if (a == 9) { Console.WriteLine("RAR?"); }
                else { Console.WriteLine("WIFI ANTENNAS"); }

            }
        }
    }
}

