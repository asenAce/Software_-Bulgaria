using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LongestSubsquence
{
    class TestLongestSequence
    {
        static void Main()
        {
            // The Input

            List<string> inputs = new List<string>()
            {
                "12 2 7 4 3 3 8",
                "2 2 2 3 3 3",
                "4 4 5 5 5",
                "1 2 3",
                "0",
            };

            List<string> results = new List<string>()
            {
                "3,3",
                "2,2,2",
                "5,5,5",
                "1",
                "0"
            };
            //The Logic

            bool worksCorrect = true;

            for (int i = 0; i < inputs.Count; i++)
            {
                var currResult = string.Join(",", LongestSubsquence.getLongestSubsequence(inputs[i]));
                if (currResult != results[i])
                {
                    worksCorrect = false;
                }
            }

            if (worksCorrect)
            {
                Console.WriteLine("The program works correct!");
            }
            else
            {
                Console.WriteLine("Not all test passed");
            }
        }


    }
}
