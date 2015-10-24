using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DivideBy7And5
{
    class Program
    {
        //Write a Boolean expression that checks for given integer 
        // if it can be divided (without remainder) by 7 and 5 in the same time. Examples:
        
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("This program will Write a Boolean expression that checks for given integer \n if it can be divided (without remainder) by 7 and 5 in the same time.");
            Console.WriteLine("************************************************************");
            Console.WriteLine("Please write your number: ");
            bool isNumber = int.TryParse(Console.ReadLine(),out number); // boolean expresion state is it true or fause.
            // id theNumber ,from right to left convert the given value from the user by .Parse method pass the value to the id
            //of type bool / boolean 
            if(isNumber) // () in the condition chech is it true of foulse ? 
            {
                if(number %7 == 0) //  Is the given number divided to 7 . %7
                {
                    Console.WriteLine(" True"); //if so , put this on the console!
                }
                else if (number % 5 == 0) //Is the given number divided to 5 . %5
                {
                    Console.WriteLine(" True"); // if so, put this message to the console.
                }
                else // in all other cases prompt this message to the console.
                {
                    Console.WriteLine(" The number does not divided to 5 nor to 7 ");
                }
                Console.Read();

            }
            
            
        }
    }
}
