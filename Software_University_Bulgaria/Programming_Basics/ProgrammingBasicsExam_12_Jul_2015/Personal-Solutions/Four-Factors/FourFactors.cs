using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Four_Factors
{
    class FourFactors
    {
        static void Main()
        {
            long FG = long.Parse(Console.ReadLine());
            long FGA = long.Parse(Console.ReadLine());
            long ThreeP = long.Parse(Console.ReadLine());
            long TOV = long.Parse(Console.ReadLine());
            long ORB = long.Parse(Console.ReadLine());
            long OppORB = long.Parse(Console.ReadLine());
            long FT = long.Parse(Console.ReadLine());
            long FTA = long.Parse(Console.ReadLine());

            double eFGPerc = (FG + 0.5 * ThreeP) / FGA;
            double TOVPerc = TOV / (FGA + 0.44 * FTA + TOV);
            double ORBPerc = (double)ORB / (ORB + OppORB);
            double FTPerc = (double)FT / FGA;

            Console.WriteLine("eFG% {0:F3}", eFGPerc);
            Console.WriteLine("TOV% {0:F3}", TOVPerc);
            Console.WriteLine("ORB% {0:F3}", ORBPerc);
            Console.WriteLine("FT% {0:F3}", FTPerc);

        }
    }
}
