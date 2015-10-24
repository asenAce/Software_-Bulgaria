using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndObjects     // Making Concatinations
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "Hello";
            string second = "World";
            string greating = first + "  " + second;        // The concatination!!

            Console.WriteLine("My Griating is {0}.", greating);      // {0} is the possition saying replace on this possitino with what ia after "." , ID greating.
            Console.ReadLine();
        }
        
    }
}
