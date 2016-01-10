using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WinningNumbers
{
    /**
     * We are given a string S consisting of capital and non-capital letters. Every letter has a value equal to its position in the English alphabet (a=1, b=2, …, z=26). First you have to calculate the sum of all letters letSum. Then, find all 6-digits numbers in range [000 000 … 999 999] called winning numbers for which the following is true: the product of the first three digits is equal to the product of the second three digits, and both of those are equal to letSum. Your task is to print on the console all winning numbers.
Input
The input data should be read from the console. It consists of 1 line:
On the first line you will be given a string S which will only consist of lower and capital case letters.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console as a sequence of winning numbers in format abc-def in ascending order. Each winning number should stay alone on a separate line. In case there are no winning numbers, print “No”.
Constraints
The string S will have maximal length of 150 characters.
Allowed working time: 0.2 seconds. Allowed memory: 16 MB.

     * 
     * 
     * */

    class WinningNumbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            int letSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                letSum += input[i] - 'a' + 1;   // to get the possition in the alphabeta
            }

            int counter = 0;

            for (int digitOne = 1; digitOne <= 9 ; digitOne++)
            {
                for (int digitTwo = 1; digitTwo<=9; digitTwo++)
                {
                    for (int digitThree = 1; digitThree <=9; digitThree++)
                    {
                        if (digitOne*digitTwo*digitThree ==letSum)
                        {
                            for (int digitFour = 1; digitFour <=9 ; digitFour++)
                            {
                                for (int digitFive = 1; digitFive <=9; digitFive++)
                                {
                                    for (int digitSix = 1; digitSix <=9; digitSix++)
                                    {
                                        if (digitFour*digitFive*digitSix==letSum)
                                        {
                                            Console.WriteLine("{0}{1}{2}-{3}{4}{5}",digitOne,digitTwo,digitThree,digitFour,digitFive,digitSix);
                                            counter++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("NO");   //100 POINTS
            }
        }
    }
}
