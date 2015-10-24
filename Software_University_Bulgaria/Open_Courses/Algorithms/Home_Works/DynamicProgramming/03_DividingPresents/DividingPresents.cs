using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Task.DividingPresents
{
    class DividingPresents
    {
        static void Main(string[] args)
        {

            int[] presents = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            int alansSum = 0;
            int bobsSum = 0;

            List<int> alansPresents = new List<int>();
            List<int> bobsPresents = new List<int>();

            Array.Sort(presents);

            for (int i = presents.Length - 1; i >= 0; i--)
            {
                if (alansSum > bobsSum)
                {
                    bobsSum = bobsSum + presents[i];
                    bobsPresents.Add(presents[i]);
                }

                else
                {
                    alansSum = alansSum + presents[i];
                    alansPresents.Add(presents[i]);
                }
            }

            Console.WriteLine("Difference: {0}", Math.Abs(alansSum-bobsSum));
            Console.WriteLine("Alan: {0} Bob: {1}", alansSum, bobsSum);
            Console.WriteLine("Alan takes: {0}", alansPresents.Count > 0 ? string.Join(",", alansPresents): "None");
            Console.WriteLine("Bob takes the rest.");

        }
    }
}
