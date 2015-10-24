using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05.Calculate1_1_
{
    class Program
    {

        /**Write a program that, for a given two integer numbers n and x, 
         * calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. Use only one loop. 
         * Print the result with 5 digits after the decimal point.
         * 
         * */


        

        static void Main(string[] args)
        {
            Console.WriteLine(" n =  ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(" x = ");
            int x = int.Parse(Console.ReadLine());

            double factN = 1;
            double multiX = 1;
            double result = 1;

            for (int i = 1; i <= n;i++ )
            {
                factN = factN * i;
                multiX = multiX * x;
                result = factN / multiX; 
            }
            Console.WriteLine("{0:F5}",result);
            Console.ReadLine();

        }
    }
}
