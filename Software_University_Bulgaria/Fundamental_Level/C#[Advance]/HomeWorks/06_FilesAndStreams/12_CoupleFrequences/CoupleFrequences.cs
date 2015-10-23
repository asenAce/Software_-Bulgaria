using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CoupleFrequences
{
    class CoupleFrequences
    {
        static void Main()
        {
            // This problem is from the Java Basics Exam (26 May 2014). You can test your solution here. Write a program that reads a sequence of n integers and calculates and prints the frequencies of all couples of two consecutive numbers. For example, for the input sequence { 3 4 2 3 4 2 1 12 2 3 4 }, we have 10 couples (6 distinct), shown on the right with their occurrence counts and frequencies (in percentage).

            string input = Console.ReadLine();

            string[] integers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> couples = new Dictionary<string, int>();
            double amountOfCouples = 0;
            for (int i = 0; i < integers.Length - 1; i++) // it is minus 1 because I want to iterate to the integer before the last otherwise the program will throw an exception when I want to acces [i+1] from the couple. 
            {
                int occurrencesOfCouple = 1;
                string couple = integers[i] + " " + integers[i + 1];

                if (couples.ContainsKey(couple))
                {
                    couples[couple]++;
                }
                else
                {
                    couples.Add(couple, occurrencesOfCouple);
                }
                amountOfCouples++;
            }

            Output(couples, amountOfCouples);
        }

        private static void Output(Dictionary<string, int> couples, double amountOfCouples)
        {
            var orderedCouples =
                couples
                    .OrderByDescending(couple => couple.Value);

            foreach (var couple in orderedCouples)
            {
                double percentageOfOccurrences = 100 / (amountOfCouples / couple.Value);
                Console.WriteLine("{0} -> {1:F2}%", couple.Key, percentageOfOccurrences);
            }
        }
    }
}
