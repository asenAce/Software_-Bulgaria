using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkTwo.cs
{
    class LastDigit
    {

        static string[] numbers =
        {
            "zero","one","two","three","four","five","six","seven","eight","nine"
        };


        static void PrintNumber(int num)
        {
            int lastDigit = num % 10;
            Console.WriteLine(numbers[lastDigit]);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("a = ");
            int a = int.Parse(Console.ReadLine());

        }
    }
}
