using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10.FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;

            while (number <= 100)
            {
                /**
                 * Note that we can introduce locals inside the block!
                 * 
                 * */

                bool fizz = number % 3 == 0;
                bool buzz = number % 5 == 0;

                bool fizzbuzz = fizz && buzz;

                if (fizzbuzz)
                {
                    Console.WriteLine("fizzbuzz");
                }

                else if (fizz)
                {
                    Console.WriteLine("fizz");
                }
                else if (buzz)
                {
                    Console.WriteLine("buzz");
                }

                number++;
            }


        }
    }
}
