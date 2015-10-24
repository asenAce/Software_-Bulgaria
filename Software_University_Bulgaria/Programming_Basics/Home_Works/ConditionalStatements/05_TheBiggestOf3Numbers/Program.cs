using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05.TheBiggestOf3Numbers
{
    class Program
    {
        /**
         * Write a program that finds the biggest of three numbers. 
         * */
        static void Main(string[] args)
        {
            Console.Write("please state a :  ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("please state b :  ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("please state c :  ");
            double c = double.Parse(Console.ReadLine());

           if( a >= b && a >= c)
           {
               Console.WriteLine("The number {0} is bigger than {1} and {2}",a,b,c);
           }
            else if ( b >= a && b >= c)
            {
               Console.WriteLine("The number {0} is bigger than {1} and {2}", b, a, c);
            }
            else if( c >= a && c >=b)
           {
               Console.WriteLine("The number {0} is bigger than {1} and {2}", c, b, a);
           }
               /**
           else if (a > b || a < c)
           {
               Console.WriteLine("The number {0} is bigger than {1} and {2}", c, a, b);
           }
           else if (a < b || b < c)
           {
               Console.WriteLine("The number {0} is bigger than {1} and {2}", c, a, b);
           }
            **/
            else if (a == b && a == c)
           {
               Console.WriteLine("The numbers are equal ");
            }
            else
           {
               Console.WriteLine("Not a number");
           }
           Console.ReadLine();


        }
    }
}
