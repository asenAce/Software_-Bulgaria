using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Four_Factors_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            long fg;
            long fga;
            long threePointFg;
            long tov;
            long orb;
            long oppDrb;
            long ft;
            long fta;

            long[] input = new long[8];
            for (int i = 0; i < 8; i++)
            {
                input[i] = long.Parse(Console.ReadLine());
            }

            fg = input[0];
            fga = input[1];
            threePointFg = input[2];
            tov = input[3];
            orb = input[4];
            oppDrb = input[5];
            ft = input[6];
            fta = input[7];

            double efgPercentage = (fg + (0.5 * threePointFg)) / fga;
            double tovPercentage = tov / (fga + (0.44 * fta) + tov);
            double orbPercentage = (double)orb / (orb + oppDrb);
            double ftPercentage = (double)ft / fga;

            Console.WriteLine("eFG% {0}", efgPercentage.ToString("0.000"));
            Console.WriteLine("TOV% {0}", tovPercentage.ToString("0.000"));
            Console.WriteLine("ORB% {0}", orbPercentage.ToString("0.000"));
            Console.WriteLine("FT% {0}", ftPercentage.ToString("0.000"));
        }
    }
}
