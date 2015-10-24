using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06.TheBiggestOfFiveNumbers
{
    class Program
    {
        //Write a program that finds the biggest of five numbers by using only five if statements. 

        static void Main(string[] args)
        {

            Console.WriteLine("The program   finds the biggest of five numbers by using only five if statements.");
            Console.WriteLine("**************************************************");
            Console.WriteLine("a = ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("b = ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("c = ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("d = ");
            double d = double.Parse(Console.ReadLine());

            Console.WriteLine("e = ");
            double e = double.Parse(Console.ReadLine());

            if((a > b) && (a>c)&&(a>d)&&(a>e))
            {
                Console.WriteLine("the number {0} is the biggest ",a);
            }
           else if ((a < b) && (b > c) && (b > d) && (b > e))
            {
                Console.WriteLine("the number {0} is the biggest ", b);
            }
           else if ((a < c) && (b > c) && (c > d) && (c > e))
            {
                Console.WriteLine("the number {0} is the biggest ", c);
            }
          else  if ((d > b) && (d > a) && (d > c) && (d > e))
            {
                Console.WriteLine("the number {0} is the biggest ", d);
            }
          else   if ((e > a) && (e> b) && (e > c) && (e > d))
            {
                Console.WriteLine("the number {0} is the biggest ", e);
            }
            else if ((a==b)&&(b==c)&&(c==d)&&(d==e))
            {
                Console.WriteLine("All the numbers are equal. ");
            }
            else
            {
                Console.WriteLine("Losho Kolarow , losho ");
            }
            Console.ReadLine();
        }
    }
}
