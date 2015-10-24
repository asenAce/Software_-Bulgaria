using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sumof5Numbers
{
    //Write a program that enters 5 numbers (given in a single line, separated by a space),
    //calculates and prints their sum. Examples:

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number:   ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number:  ");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the 3-th number:  ");
            double thirdNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the 4-th number:  ");
            double fourthNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the 5-th number:  ");
            double fifthNumber = double.Parse(Console.ReadLine());

            double theSum = (firstNumber + secondNumber) + (thirdNumber + fourthNumber) + fifthNumber ;

            Console.WriteLine("The sum of the chosen numbers is : \n{0}",theSum);
            Console.ReadLine();
        }
    }
}
