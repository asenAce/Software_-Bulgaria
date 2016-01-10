using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintToTheConsoleOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Peter";
            int age = 18;
            string town = "Sofia";

            Console.Write("{0} is {1} year old from {2}. " , name,age,town);
            Console.Write("This is on the same line!");
            Console.WriteLine("Next sentence will be on a new line.");

            Console.WriteLine("Bye,bye, {0} from {1}.", name, town);   
        }
    }
}
