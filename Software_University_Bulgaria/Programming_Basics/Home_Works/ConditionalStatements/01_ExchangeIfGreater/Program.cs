using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.ExchangeIfGreater
{
    class Program
    {

        /**
         * Write an if-statement that takes two integer variables a and b and exchanges their values if the first one is greater than the second one.
         * As a result print the values a and b, separated by a space. 
         * */
        static void Main(string[] args)
        {

            Console.WriteLine("Please write value for a:  ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Please write value for b:  ");
            double b = double.Parse(Console.ReadLine());

            if( a>b)
            {
                Console.WriteLine("The result is {0} > {1} ",a,b);
            }
            else if(a < b)
            {
                Console.WriteLine("The result is {0} < {1} ",a,b);
            }
                else if(a == b)
                {
                    Console.WriteLine("The result is {0} = {1} ",a,b);
                }

            else 
            {
                Console.WriteLine("You got to be kidding me :-p ");
                
            }
            Console.ReadLine();
           
        }

    }
}
