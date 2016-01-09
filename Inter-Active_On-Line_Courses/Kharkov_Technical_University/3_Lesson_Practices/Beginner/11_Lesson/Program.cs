using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11.Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int number = 1; number <= 100; number++)
            {
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
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }


        }
    }
}
