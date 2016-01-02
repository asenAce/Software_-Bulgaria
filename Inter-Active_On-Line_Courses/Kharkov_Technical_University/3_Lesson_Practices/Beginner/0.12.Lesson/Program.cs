
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12.Lesson
{
    /**
     * Input 
     * 
     * 
     * */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?  ");
      //      string name = Console.ReadLine();
      //      Console.WriteLine("Hello {0}",name);

            // age
            Console.WriteLine("How old are you? ");

            //Parsing turns strings into other data types.
            string userInput = Console.ReadLine();
            int age = int.Parse(userInput);     // giving a paramethers or athributes
            Console.WriteLine("{0} is my age",age);

            /**
             * Failures handling exaptions
             * */

            bool isSuccess  = int.TryParse(userInput, out age);

            if (isSuccess)
            {
                Console.WriteLine("{0} this is my age",age);
            }

            else
            {
                Console.WriteLine("{0} is not an age",userInput);
            }

            //Dealing with empty spaces

            /**

            string name;
            do
            {
                Console.WriteLine("What is my name?");
                name = Console.ReadLine(); 
            } while (name.Length == 0 );
            Console.WriteLine("Hello, {0}!  ", name);
            **/

            // frendly

            string name; //Declating the variable first

            while (true)
            {
                Console.WriteLine("What is your name?");
                name = Console.ReadLine();  // Assign a value to the var name; 
                if (name.Length == 0) //if the condition is met  blank space
                {
                    Console.WriteLine("That is not a name."); //Execute this code block
                    continue; // until is not true
                }
                else // Outherwise do this
                {
                    break;
                }

            }
            Console.WriteLine("Hello , {0}",name);

        }
    }
}
