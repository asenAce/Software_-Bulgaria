using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.KingOfThieves
{
    /**
     * Once upon a time there was a kingdom and everyone in the kingdom was a thief. Izzy wanted to become the King of 
     * Thieves and so started stealing only perfect gems from other thieves. Help Izzy by showing him what a perfect gem 
     * with given parameters should look like.
     * 
Input
The input data should be read from the console. 
The first line will hold the size of the gem – n.
The second line will hold the type of the gem – a symbol: e.g. ‘*’.
The input data will always be valid and in the format described. There is no need to check it explicitly.
     * 
Output
The output should be printed on the console. It should consist of ‘n’ lines, holding the gem.
Constraints
The number n will be a positive odd integer between 3 and 59, inclusive.
The type of the gem will be a symbol from the standard ASCII table.
Allowed working time for your program: 0.1 seconds.
Allowed memory: 16 MB.

     * 
     * */


    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            int symbolCount = 1;
            for (int row = 0; row < size; row++)
            {
                string halfDashes = new string('-', (size - symbolCount) / 2); // negative number !
                string gemSymbol = new string(symbol,symbolCount);
                Console.WriteLine("{0}{1}{0}",halfDashes,gemSymbol);

                if (row < (size) / 2)
                {
                    symbolCount += 2;
                }
                else 
                {
                    symbolCount -= 2;
                }
            }



        }
    }
}
