using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoopTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  n = ? ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n;  i +=2)
            {
                if ( i % 7 == 0)
                {
                    continue;
                }
                sum += 1;
            }

        }
    }
}
