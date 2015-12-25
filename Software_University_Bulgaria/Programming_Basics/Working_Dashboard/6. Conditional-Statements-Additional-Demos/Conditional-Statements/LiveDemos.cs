using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    class LiveDemos
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int b = Int32.Parse(Console.ReadLine());
            object c = 


            switch (a)
            {
                case "a":
                    Console.WriteLine("The letter is A!");
                    break;
                case "A":
                    if (b > 0)
                    {

                    }
                    Console.WriteLine("The letter is A!");
                    break;
                case "b":
                case "B":
                    Console.WriteLine("The letter is B!");
                    break;
                default:
                    Console.WriteLine("The letter is not defined yet!");
                    break;
            }
        }
    }
}
