using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c and prints them in 4 virtual columns on the console. Each column should have a width of 10 characters. The number a should be printed in hexadecimal, left aligned; then the number a should be printed in binary form, padded with zeroes, then the number b should be printed with 2 digits after the decimal 
 * point, right aligned; the number c should be printed with 3 digits after the decimal point, left aligned. Examples:
 * */

namespace _05.FormattingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter an integar a from 0 to 500:  ");
            int integarA = int.Parse(Console.ReadLine());

            Console.Write("Please Enter floating point b:");
            double floatingPointB = double.Parse(Console.ReadLine());

            Console.Write("Please Enter floating point c:  ");
            double floatingPointC = double.Parse(Console.ReadLine());

            Console.Write("|{0,10:X}    |" ,integarA);
            Console.Write("{0}|",Convert.ToString(integarA,2).PadLeft(10,'0'));
            Console.Write("     {0:0.00}|",floatingPointB);
            Console.Write("{0:0.000}    | ",floatingPointC);
            Console.Read();
        }
    }
}
