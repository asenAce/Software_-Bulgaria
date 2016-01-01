using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Create a Function that add two numbers,does not return any value!!
 * */

namespace ChallengeOneCreateAFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum(32, 45);             //At this line we give the values!
        }


        static void Sum(int numOne, int numTwo)     // () this is a place holder known as arguments for the Function! 
        {
            int sum = numOne + numTwo;              //This is the formula for calculate the sum
            Console.WriteLine(sum);
            Console.Read();
        }

        }
}
