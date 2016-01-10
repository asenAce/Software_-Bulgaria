using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddorEvenCounter
{


    /****
     * Odd or Even Counter
Petko is bad with numbers. He’s given a task to find and count some, but he has a hard time doing it. He is given N sets of numbers, and he has to count the odd numbers in each set, and then compare them. The number C shows how many numbers are there in a set. Then you are given a string S holding one of the words "odd" or "even" showing you what numbers should be counted.  Then you are given N * C numbers representing all sets.
Your task is to count the odd or even numbers in each set, and then say in which set has most S numbers.
The set with most S numbers should be represented as ordinal number word e.g. "First", "Second", "Third", "Fourth", "Fifth", "Sixth", "Seventh", "Eighth", "Ninth", "Tenth". If the count of one or more sets is equal, print the first one with biggest count. If there is no set holding odd or even numbers print "No".  
Input
The input data should be read from the console. It consists of three input values, each at separate line:
The first line holds an integer N – the count of sets
The second line hold an integer C – the count of numbers in each set
The third line holds a string S  holding either "odd" or "even" showing what numbers to count
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data should be printed on the console. It consists of exactly 1 line.
Print on the console the following formatted string "{0} set has the most {1} numbers: {2}", where {0} is the set as ordinal string {1} is the value of S and {2} is the biggest count of S numbers. If there is no set holding odd or even numbers print "No".   

     * Constraints
N will be an integer number in the range [1...10] 
C will be an integer number in the range [1...50] 
Each of the numbers in the set will be an integer in the range[-2 147 483 647… 2 147 483 647]
Allowed working time for your program: 0.25 seconds. Allowed memory: 16 MB.

     * 
     * 
     * 
     * */

    class OddorEven
    {
        static void Main(string[] args)
        {

            int setCount = int.Parse(Console.ReadLine());
            int numberSet = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            int[] totalCount= new int[setCount];

            for (int index = 0; index < setCount; index++)
            {
                for (int innerIndex = 0; innerIndex < numberSet;innerIndex++ )
                {
                    int currentNumber = int.Parse(Console.ReadLine());
                    if (type == "odd")
                    {
                        if (currentNumber % 2 == 1) // left 1 means that the number is odd , 
                        {
                            totalCount[index]++;
                        }
                    }

                    else
                    {
                        if (currentNumber % 2 == 0) // This is how we chech the number is it even % 2 divided on 2 with left over 0
                        {
                            totalCount[index]++;
                        }
                    }
                }
            }

            int maxCount = 0;
            int maxIndex = -1;

            for (int index = 0; index < totalCount.Length; index++)
            {
                
                if (totalCount[index] > maxCount)
                {
                    maxCount = totalCount[index];
                    maxIndex = index;
                }
            }

            if (maxIndex == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                switch (maxIndex + 1)
                {
                    case 1:
                        Console.WriteLine("First");
                        break;
                    case 2:
                        Console.WriteLine("Second");
                        break;
                    case 3:
                        Console.WriteLine("Third");
                        break;
                    case 4 :
                        Console.WriteLine("Fourth");
                        break;
                    case 5:
                        Console.WriteLine("Fifth");
                        break;
                    case 6:
                        Console.WriteLine("Sixth");
                        break;
                    case 7:
                        Console.WriteLine("Seventh");
                        break;
                    case 8:
                        Console.WriteLine("Eighth");
                        break;
                    case 9:
                        Console.WriteLine("Tenth");
                            break;
                    default:
                        break;
                }
                Console.WriteLine("set has the most {0} numbers:  {1}",type,maxCount);
            }

        }
    }
}
