using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10.Fibonacci_Numbers
{
    class Program
    {
        /**
         * Write a program that reads a number n and prints on the console
         * the first n members of the Fibonacci sequence (at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. 
         * Note that you may need to learn how to use loops. Examples:
         * */
        static void Main(string[] args)
        {
            Console.WriteLine("Please state n =  ");
            int n = int.Parse(Console.ReadLine());
            int BigIntegerFirst = 0;
            int BigIntegerSecond = 1;
            int BigIntegerThird =   BigIntegerFirst + BigIntegerSecond;
                 



            if (n ==1)
            {
                Console.WriteLine(0);
            }
              else if  (  n == BigIntegerFirst)
            {
                Console.WriteLine(BigIntegerFirst);
            }

                for ( int i = 2; i < n ; i++)
                {
                    Console.Write(BigIntegerThird + "");
                
                }
                Console.ReadLine();
                }



        }
    }
}
