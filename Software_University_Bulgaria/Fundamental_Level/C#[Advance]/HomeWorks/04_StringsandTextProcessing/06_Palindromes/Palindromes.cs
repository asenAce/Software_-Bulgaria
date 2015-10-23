using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSix.cs
{
    class Palindromes
    {
        static void Main(string[] args)
        {

            Console.WriteLine("input");
            string [] input = Console.ReadLine().Split(new char[]{',',';','!','.',' ','?'},StringSplitOptions.RemoveEmptyEntries);
            SortedSet<string> palindromes = new SortedSet<string>();

            foreach (string item in input)
            {
                if (isPalindrome(item))
                {
                    palindromes.Add(item);
                }
                
            }

            Console.WriteLine(string.Join(",",palindromes));

        }


        static bool isPalindrome(string x)
        {
            // declare the variables.
            int startIndex = 0;
            int lastIndex = x.Length - 1;
            int iterations = x.Length / 2;

            bool hasMatch = false;

            for (int i = 0; i <= iterations; i++)
            {
                if (x[startIndex] == x[lastIndex])
                {
                    startIndex++;
                    lastIndex--;
                    hasMatch = true;
                    continue;
                }

                else
                {
                    hasMatch = false;
                    break;
                }
            }

            return hasMatch;



        }


    }
}
