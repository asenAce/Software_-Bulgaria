using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Please enter your last name:  ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Your full name is  {0}   {1}",firstName,lastName);
            Console.Read();

        }
    }
}
