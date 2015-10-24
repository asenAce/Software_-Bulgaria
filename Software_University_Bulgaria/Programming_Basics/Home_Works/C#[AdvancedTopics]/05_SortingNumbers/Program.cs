using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortingNumbers
{
    class Program
    {

        /**
         * Write a program that 
         * reads a number n and a sequence of n integers, sorts them and prints them.
         * */
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i ++ )
            {
                var number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }

            numbers.Sort();

            for (int i = 0; i < n; i++ )
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}
