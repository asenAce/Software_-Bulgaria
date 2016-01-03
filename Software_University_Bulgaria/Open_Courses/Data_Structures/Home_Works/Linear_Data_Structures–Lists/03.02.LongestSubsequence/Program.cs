using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._02.LongestSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            List<int>inputList = new List<int>();
            string input = Console.ReadLine();
            input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList().ForEach(el => inputList.Add(int.Parse(el)));

            List<int> resultList = GetLeftMostLonguestSequence(inputList);

            resultList.ForEach(el => Console.Write(el + " "));
            Console.WriteLine();

            //Logic

       


            //Output

        }

        private static List<int> GetLeftMostLonguestSequence(List<int> input)
        {
            int count = 1;
            int maxCount = 1;
            int number = input[0];

            List<int> result = new List<int>(input.Count);

            for (int i = 1; i < input.Count; i++)
            {
                if (input[i] == input[i - 1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        number = input[i];
                        
                    }
                }

                else
                {
                    count = 1;
                }
                
            }

            //return Enumerable.Repeat(number,maxCount).ToList();  -slow  but fast written solution

            for (int i = 0; i < maxCount; i++)
            {
                result.Add(number);
            }


            return result;
        }


    }
}
