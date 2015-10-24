using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.NumbersFrom1toN
{

    /**
     * Write a program that enters from the console
     * a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space. 
     * 
     * */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n =  ? ");
            int theNumber = int.Parse(Console.ReadLine());
            int start = 0;

            for (; theNumber > start;theNumber-- )
            {
                Console.WriteLine(" The result {0}",theNumber);
            };
            Console.ReadLine();

        }
    }
}
