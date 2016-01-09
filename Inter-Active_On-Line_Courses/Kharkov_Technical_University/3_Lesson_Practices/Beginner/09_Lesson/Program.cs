using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fizz-buzz
            int number = 1;

            while (number <= 100)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if (number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if ( number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                
                else  
                {
                    Console.WriteLine(number);
                    number++;
                }

            }
            // Why did we stop at 99?

        }
    }
}
