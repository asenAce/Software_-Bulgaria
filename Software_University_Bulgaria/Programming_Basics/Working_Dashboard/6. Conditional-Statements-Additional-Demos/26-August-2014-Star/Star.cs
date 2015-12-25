using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_August_2014_Star
{
    class Star
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n / 2; i++)
            {
                string outerDots = new string('.', n - i);
                if (i == 0)
                {
                    Console.WriteLine("{0}{1}{0}", outerDots, "*");
                }
                else
                {
                    string innerDots = new string('.', 2 * i - 1);
                    Console.WriteLine("{0}{1}{2}{1}{0}", outerDots, "*", innerDots);
                }
            }

            string arm = new string('*', n / 2 + 1);
            string innerDotsForArm = new string('.', n - 1);
            Console.WriteLine("{0}{1}{0}", arm, innerDotsForArm);
            for (int i = 1; i < n / 2; i++)
            {
                string outerMiddleDots = new string('.', i);
                string innerMiddleDots = new string('.', 2 * n - 1 - 2 * i);
                Console.WriteLine("{0}{1}{2}{1}{0}", outerMiddleDots, "*", innerMiddleDots);
            }

            for (int i = 0; i < n / 2; i++)
            {
                string outerLegDots = new string('.', n / 2 - i);
                string legDots = new string('.', n / 2 - 1);
                if (i == 0)
                {
                    Console.WriteLine("{0}{1}{2}{1}{2}{1}{0}", outerLegDots, "*", legDots);
                }
                else
                {
                    string innerLegDots = new string('.', 2 * i - 1);
                    Console.WriteLine("{0}{1}{3}{1}{2}{1}{3}{1}{0}", outerLegDots, "*", innerLegDots, legDots);
                }
            }

            Console.WriteLine("{0}{1}{0}", arm, innerDotsForArm);
        }
    }
}
