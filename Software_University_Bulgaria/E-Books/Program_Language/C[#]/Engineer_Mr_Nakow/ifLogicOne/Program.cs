using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifLogicOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter two numbers:  ");
            Console.WriteLine("Please enter the first number:  ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number:  ");
            int secondNumber = int.Parse(Console.ReadLine());
            int biggerNumber = firstNumber;

            if( secondNumber > firstNumber) // boolen expresion 
            {
                biggerNumber = secondNumber;
            }
            Console.WriteLine("The biggest number is: {0}",biggerNumber);
            Console.ReadLine();
        }
    }
}
