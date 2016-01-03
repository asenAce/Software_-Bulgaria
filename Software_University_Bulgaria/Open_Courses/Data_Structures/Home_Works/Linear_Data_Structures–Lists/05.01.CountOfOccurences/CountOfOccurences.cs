
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._01.CountOfOccurences
{
    class CountOfOccurences
    {
        private static List<int> numbers;

        static void Main(string[] args)
        {
            // The Input

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

            CountOccurences();

            //The Output

        }

        private static void CountOccurences()
        {
            var ocurrenceDisct = numbers.GroupBy(z => z).ToDictionary(y => y.Key, y => y.Count());
            PrintDictionary(ocurrenceDisct);
        }

        private static void PrintDictionary(Dictionary<int,int> dict)
        {
            foreach (var item in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine("{0} --> {1} time(s)",item.Key,item.Value);
            }
        }
    }
}
