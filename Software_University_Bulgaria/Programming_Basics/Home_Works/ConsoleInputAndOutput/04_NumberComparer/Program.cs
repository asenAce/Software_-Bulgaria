using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumberComparer
{
    //Write a program that gets two numbers from the console and prints the greater of them. 
    //Try to implement this without if statements. Examples:

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write your first chosen number: "); //OutPut to the console asking the loser pardon the user
            //for his/her number pass the chose...
            int firstNumber = int.Parse(Console.ReadLine()); // ... to  a variable with name of theNumber with type int..
            
            Console.WriteLine("Please write your second chosen number: ");
            int secondNumber = int.Parse(Console.ReadLine());
        /**
            string someString;

            if (Console.ReadLine() == string )
            {
                Console.WriteLine("Letters are not alowed,please write some numbers! ");
            }
            May some body tell me how to write a code that will handle ,if the user write letters insted of numbers
         * Should i use try catch logic and how??  **/
            if(firstNumber > secondNumber)
            {
                Console.WriteLine("{0} is Greater than {1}",firstNumber,secondNumber); //Again i am using placeholder
            }
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine("{0} is less than {1}",firstNumber,secondNumber);
            }
            else
            {
                Console.WriteLine("{0} is equal to {1}",firstNumber,secondNumber);
            }
            Console.ReadLine();
        }
    }
}
