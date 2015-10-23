using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorks.cs
{
    class HomeWorkOne
    {
        /*
         * BiggerNumber___
         * */

        


        static void Main(string[] args)
        {

            Console.WriteLine("firts =   ");
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("second = ");
            int second = int.Parse(Console.ReadLine());

            int max = GetMax(first,second);
            Console.WriteLine(GetMax);

        }

        public    class BiggerNumber
        {
            public static int GetMax(int a, int b)
            {
                int c = Math.Max(a,b);
                return c;
            }
        }

        /*
        class BiggerNumber
        {
            static int GetMax(int a, int b)
            {
                int c = Math.Max(a, b);
                return c;
            }


        }
         * */
    }
}
