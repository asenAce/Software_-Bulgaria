using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02.NumbersNotDivisibleBy3and7
{
    class Program
    {
        /**
         * Write a program that enters from the console a positive integer n and prints 
         * all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space. 
         * */

        static void Main(string[] args)
        {
            Console.WriteLine(" Please state the possitive n:   ");
            int n = int.Parse(Console.ReadLine());
            

            for (int i=1; n >= i; i++ )
            {
                if( i % 3 ==0 || i  % 7 == 0)  // why is i but not n here??
                {
                    continue;  // what is this???
                }
                else  
                {
                    Console.WriteLine(" the result {0}",i);  //what role play -3 here??
                };

            };
            Console.ReadLine();
        }
    }
}
