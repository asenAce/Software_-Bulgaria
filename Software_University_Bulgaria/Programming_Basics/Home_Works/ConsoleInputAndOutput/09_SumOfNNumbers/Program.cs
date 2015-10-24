using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SumOfNNumbers
{
    /**
     * Write a program that enters a number n and after that enters more n 
     * numbers and calculates and prints their sum. Note that you may need to use a for-loop. Examples:
     * */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write your number:  ");
            long number = long.Parse(Console.ReadLine());
            decimal sum = 0.00m;
           // decimal number = decimal.MinValue;


            for (int i = 0; i < number; i ++ )
            {
                number = decimal.Parse(Console.ReadLine());
                sum += number;

            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
