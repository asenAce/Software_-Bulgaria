using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TaskFive.cs
{
    class ValidUserNames
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[a-zA-Z][\w_]{2,24}\b";

            Console.WriteLine("input");
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input,pattern);

            int maxSum = 0;
            string nameOne = string.Empty;
            string nameTwo = string.Empty;

            for (int i = 0; i < matches.Count-1; i++)
            {
                int currentSum = matches[i].Length + matches[i + 1].Length;

                if (maxSum < currentSum || maxSum == 0)
                {
                    maxSum = currentSum;
                    nameOne = matches[i].Value;
                    nameTwo = matches[i + 1].Value;
                }
            }


            Console.WriteLine(nameOne);
            Console.WriteLine(nameTwo);
        }

        

    }
}
