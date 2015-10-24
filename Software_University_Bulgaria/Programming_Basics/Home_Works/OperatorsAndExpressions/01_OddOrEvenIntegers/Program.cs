using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OddOrEvenIntegers
{
    //Write an expression that checks if given integer is odd or even. Examples:

    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Please state your number:  ");
            bool isInt = int.TryParse(Console.ReadLine(),out number);
            if( isInt)
            {
                if(number %2 == 0)
                {
                    Console.WriteLine("The number is even.");
                }
                else
                {
                    Console.WriteLine("The number is odd. ");
                }
            }
            else
            {
                Console.WriteLine("Not a number!");
            }
            Console.Read();
            

        }
    }
}
