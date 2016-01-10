using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Lesson
{
    class Program
    {
        /*
         * Chapter IV 
         * */

        static void Main(string[] args)
        {
            /*
             * const int HIGH = 10, LOW = 5;      
             * string numberString;     
             * int number;     
             * Console.Write("Enter an integer ");      
             * numberString = Console.ReadLine();     
             * number = Convert.ToInt32(numberString); 
             * 
             * if(number > LOW)          
             * if(number < HIGH)            
             * Console.WriteLine("{0} is between {1} and {2}",number, LOW, HIGH);
             * */


            const int HIGH = 10, LOW = 5;  // declare variables assign value to it.
            string numberString;           // declare variable 
            int number;

            Console.WriteLine("Enter an integer");   // promp the user
            numberString = Console.ReadLine();       // store the value as string
            number = Convert.ToInt32(numberString);  
            // from right to left () passing parameter numberString ex command Convert.ToInt32 after convert 
            //assign = the value in variable number ; end

            if (number > LOW)
            {
                if (number > HIGH)
                {
                    Console.WriteLine( "{0} is between {1} and {2}",number,LOW,HIGH );
                }
            }

            Console.WriteLine( "the {0} is > than {1}",number,LOW );
            Console.Read();
        }
        
    }
}
