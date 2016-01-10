using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WeirdCombinations
{
    /**
     * You are given a sequence of 5 distinct numbers and/or letters. Find all possible combinations of 5 symbols containing the given numbers/letters. Then you will be given a number n. You have to find the n-th number in the natural order of all combinations. Example: sequence = "a1bc2", n = 5, combinations: "aaaaa", "aaaa1", "aaaab", "aaaac", "aaaa2", "aaa1a", "aaa1b"…  "2222b", "2222c", "22222".  5th element = aaa1a (take notice that the first element in the order is counted as 0). If the n-th number doesn't exist in print "No".
Input
Input data is read from the console.
The sequence of letters/numbers stays at the first line.
The number n of stays at the second line.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data must be printed on the console.
Print the n-th number in the natural order of all combinations.
Constraints
N will be an integer number between 0 and 5000 and 
Time limit: 0.25 seconds. Allowed memory: 16 MB.
     * */

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int targetCount = int.Parse(Console.ReadLine());
            bool resultFound = false;

            int count = -1; 

            for (int first = 0; first < input.Length; first++)
            {
                for (int second = 0; second < input.Length; second++)
                {
                    for (int third = 0; third < input.Length; third++)
                    {
                        for (int fourth = 0; fourth < input.Length; fourth++)
                        {
                            for (int fifth = 0; fifth < input.Length; fifth++)
                            {
                                if (count == targetCount)
                                {
                                    string output = ""+input[first]+input[second]+input[third]+input[fourth]+input[fifth];
                                    Console.WriteLine(output);
                                    resultFound = true;
                                }

                                count++;
                            }
                        }
                        
                    }
                    
                }
                
            }

            if (resultFound)
            {
                Console.WriteLine("No"); 
            }

        }
    }
}
