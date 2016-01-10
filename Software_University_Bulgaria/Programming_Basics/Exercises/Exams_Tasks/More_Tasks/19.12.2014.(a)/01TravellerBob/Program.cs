using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01TravellerBob
{

    /**
     * Bob loves travelling by plane. Thankfully, his job of being a businessman involves traveling a couple of times during the month. Bob is a busy man. He has months when he uses his private jet in order to go and sign new contracts. In a contract month, he travels 3 times per week. Although Bob loves his work, he also cares about his family. He spends family months, when he has 1 less travel per week than a contract month and he travels only 2 weeks. The other months are considered "normal" during which Bob travels 2/5 less than during contract months.
In addition, if the year is leap, Bob travels 5% more overall. Assume that a month has exactly 4 weeks. 
Your task is to write a program that calculates how many times Bob travels around the world during the year (rounded down to the nearest integer number).
Input
The input data should be read from the console. It consists of three input values, each at separate line:
The string "leap" for leap year or "normal" for year that is not leap.
The number c – number of months Bob signs contracts in the year.
The number f – number of months that Bob spends with his family.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data must be printed on the console.
On the only output line you must print the number of travels as integer.
Constraints
The numbers c is in range [0...12] and f is in range [0…12].
Allowed working time for your program: 0.25 seconds.
Allowed memory: 16 MB.
Examples

     * 
     * 
     * */

    class Program
    {
        static void Main(string[] args)
        {

            string isLeap = Console.ReadLine();
            int contracts = int.Parse(Console.ReadLine());
            int family = int.Parse(Console.ReadLine());


            double numberOfTravels = contracts * 12;
            numberOfTravels += family * 4;
            numberOfTravels += (12 - contracts - family) * 12.0 * 3 / 5;

            if (isLeap == "leap")
            {
                numberOfTravels += numberOfTravels * 5 / 100;  // 5% more 
            }

            Console.WriteLine("{0:F0}",numberOfTravels);  // Math.Round rounded to the uper value Math.Floor is rounded down.
        }
    }
}
