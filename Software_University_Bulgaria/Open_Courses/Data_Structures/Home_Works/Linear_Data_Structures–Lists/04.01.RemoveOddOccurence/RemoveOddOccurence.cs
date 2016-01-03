using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._01.RemoveOddOccurence
{
    // With exception


    class RemoveOddOccurence
    {
        private static List<int> numbers;

        static void Main(string[] args)
        {
            //The Input
            var line = Console.ReadLine();

            //The Logic
            if (!String.IsNullOrWhiteSpace(line))
            {
                numbers = line.Split().Select(int.Parse).ToList();
            }

            else
            {
                // Throwing exception!
                throw new NullReferenceException("Collection can not be null or empty! ");
            }

            var newlist = RemoveOddOccurence();
            Console.WriteLine(String.Join(" ", newlist));

        }

        // Writing Function
        static List<int> RemoveOddOccurence()
        {
            var dictionaryNumbers = numbers.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
            List<int> evenNumber = new List<int>();

            // Pass throw each element number in the dictionaryNumbers
            foreach (var number in dictionaryNumbers)
            {
                // Check if the number is even divided on 2 and is equa to 0...
                if (number.Value%2 == 0)
                {
                    evenNumber.AddRange(Enumerable.Repeat(number.Key, number.Value));
                }
            }

            return evenNumber;

        }

        



    }
}
