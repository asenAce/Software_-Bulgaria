using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * About Properties
             * 
             * 
             * */

            string greeting = "Hello world";
            int theLength = greeting.Length;

            // Instance method.
            Console.WriteLine(greeting.ToUpper());

            //Methods returns a value, does not mutate string
            greeting.ToUpper();
            Console.WriteLine(greeting);
            greeting = greeting.ToUpper();
            Console.WriteLine(greeting);

            //Methods take arguments ()
            string theSubstring = greeting.Substring(1,5); //Start at possition 1 and end on 5

            // String can be compared

            string nameOne = "Meandme";
            string nameTwo = "YouandYou";

            bool theResult =(nameOne == nameTwo);

            //This is a static method
            int comparison = string.Compare(nameOne,nameTwo);
             
            //Everything has a "ToString()" instance method.

            int number = 123;
            string text = number.ToString();












        }
    }
}
