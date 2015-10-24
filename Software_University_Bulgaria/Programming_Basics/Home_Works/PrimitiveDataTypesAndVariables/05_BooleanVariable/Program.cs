using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputValue = Console.ReadLine();      // This read a data from the user!
            bool isFemale = inputValue == "girl";       // Store the value from the user in the variable called inputValue , this is the ID 
            bool isMale = inputValue == "boy";          // We use the variable inputValue to compare girl or boy == is it equal to....

            if (isFemale)
            {
                Console.WriteLine( "it is a girl");
                
            }
            else if (isMale)
            {
                Console.WriteLine("It is a boy");
            }
            else
            {
                Console.WriteLine("You are an Alian");
            }

Console.Read();
        }
    }
}
