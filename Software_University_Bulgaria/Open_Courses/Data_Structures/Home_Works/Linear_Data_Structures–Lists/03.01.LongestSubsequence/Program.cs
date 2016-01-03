using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._01.LongestSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //The Input
            List<int> numbers = new List<int>();
            var line = Console.ReadLine(); 


            //The Logic
            if (!String.IsNullOrWhiteSpace(line))
            {
                numbers = line.Split().Select(int.Parse).ToList();
            }

            else
            {
                throw new NullReferenceException("Collection can not be null or empty!");
            }

            var subSequence = FindLongestSubsequence(numbers);
            Console.WriteLine(string.Join(" ",numbers) + " < Longest > -->" + string.Join(" ",subSequence));

        }

        static List<int> FindLongestSubsequence(List<int> source)
        {
            int bestElement = source[0];
            int bestCount = 1;

            int currentElement = source[0];
            int counter = 1;

            for (int i = 1; i < source.Count; i++)
            {
                if (currentElement.CompareTo(source[i]) == 0)
                {
                    counter++;
                    if (counter >= bestCount)
                    {
                        bestCount = counter;
                        bestElement = currentElement;
                    }
                    
                }

                if (currentElement.CompareTo(source[i]) != 0)
                {
                    currentElement = source[i];
                    counter = 1;
                }
            }

            if (currentElement.CompareTo(bestElement) != 0 && counter >= bestCount)
            {
                bestElement = currentElement;
                bestCount = counter;
            }

            var longestSubsequence = Enumerable.Repeat(bestElement, bestCount).ToList();
            return longestSubsequence;

        }
    }
}
