using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SumUnlimitedAmountOfCoins
{
    class SumUnlimitedAmountOfCoins
    {

        private static int combinationsCount;
        private static bool[] usedCoins;

        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split();
            string[] secondLine = Console.ReadLine().Split();

            int targetSum = int.Parse(firstLine[firstLine.Length - 1]);

            int[] coins = secondLine[secondLine.Length - 1].Split(new[] { '{', '}', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            Array.Sort(coins);

            usedCoins = new bool[coins.Length];

            GenerateCombinations(coins, 0, targetSum);

            for (int i = 1; i < coins.Length; i++)
            {
                if (coins[i] != coins[i-1])
                {
                    usedCoins = new bool[coins.Length];
                    int currentIndex = i;
                    GenerateCombinations(coins, currentIndex, targetSum);
                }
            }

            Console.WriteLine(combinationsCount);


        }

        private static void GenerateCombinations(int[] coins, int currentIndex, int targetSum)
        {
            if (currentIndex >= coins.Length)
            {
                return;
            }

            int diff = targetSum - coins[currentIndex];

            if (diff == 0)
            {
                usedCoins[currentIndex] = true;
                combinationsCount++;
            }

            else if (diff > 0)
            {
                for (int i = currentIndex + 1; i < coins.Length; i++)
                {
                    if (!usedCoins[i])
                    {
                        usedCoins[i] = true;
                        GenerateCombinations(coins,i,diff);
                    }
                }
            }
        }
    }
}
