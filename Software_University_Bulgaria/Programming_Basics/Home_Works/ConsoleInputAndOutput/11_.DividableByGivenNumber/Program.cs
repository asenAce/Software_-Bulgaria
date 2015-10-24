using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11.NumbersInIntervalDividableByGivenNumber
{
    /**
     * Write a program that reads two positive integer numbers and prints how many numbers 
     * p exist between them such that the reminder of the division by 5 is 0. Examples:
     * */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give a value for start:  ");
            long start = long.Parse(Console.ReadLine());
            Console.WriteLine("Please give a value for end:   ");
            long end = long.Parse(Console.ReadLine());
            int count = 0;

            for (long i = start; i <= end; i ++ )
            {
                if(i%5 == 0 )
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
