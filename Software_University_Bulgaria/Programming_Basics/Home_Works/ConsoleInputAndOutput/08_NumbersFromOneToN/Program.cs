using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.NumbersFromOneToN
{

    //Write a program that reads an integer number n from the console and prints all the numbers in the 
    //interval [1..n], each on a single line. Note that you may need to use a for-loop. 
    
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please write some number :  ");  // Out put the program prompt on the console instruction to the user;
            int theNumber = int.Parse(Console.ReadLine()); // The given value from the user and it's stored it in the variable
            //with name theNumber ID  and with type int, but before that it converted using the method .Parse which is a method bellong to
            //the int class.

            for(int i = 1; i <= theNumber; i++ ) //If logic () in the brakets we state the condition  start from 1, =< to the given value
                //, increment every time with +1.
            {
                Console.WriteLine(i);   // Out put the result on the console
            }
            Console.ReadLine();

        }
    }
}
