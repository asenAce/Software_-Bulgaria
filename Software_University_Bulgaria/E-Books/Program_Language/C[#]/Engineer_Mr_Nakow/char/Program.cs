using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @char
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare a variables
            char symbol = 'a';
            //Print the result on the console
            Console.WriteLine("The code of  " + symbol + "' is: " + (int) symbol);
            symbol = 'A';
            Console.WriteLine("The code of  ' " + symbol + "'  is: " + (int)symbol);
            Console.Read();

        }
    }
}
