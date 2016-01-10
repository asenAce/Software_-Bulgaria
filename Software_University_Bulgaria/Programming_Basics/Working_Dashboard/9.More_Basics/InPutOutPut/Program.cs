using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationExercices4ConsolesInPutOutPut
{
    class Program
    {
        static void Main(string[] args)             // The example with letter
        {
            Console.Write("Enter person name:  ");
            string person = Console.ReadLine();     //first phase.

            Console.Write("Enter the company name:  ");
            string companyName = Console.ReadLine(); //second phase.

            Console.WriteLine("Dear {0} ,  ", person);
            Console.WriteLine("We are pleased to tell you that " + "{1} has accepted you to take part in the \"C# basic\""  + " course. {1} wishes you a good luck!", person, companyName);

            Console.WriteLine ("  Yours,");
            Console.WriteLine("  {0} ", companyName);
            Console.Read();
        }
        
    }
}
