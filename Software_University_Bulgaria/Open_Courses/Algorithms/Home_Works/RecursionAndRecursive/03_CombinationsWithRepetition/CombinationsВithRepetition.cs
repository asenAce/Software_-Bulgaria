using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskThree.cs
{
    using System;
    using System.Collections.Generic;

    internal class CombinationsВithRepetition
    {
        private const int start = 1;
        private static List<int> nums = new List<int>();
        private static int loops = 0;

        private static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            Loop(n, k, start);
        }

        private static void Loop(int n, int k, int start)
        {
            if (k == 0)
            {
                Console.WriteLine(string.Join(" ", nums));
                return;
            }

            for (int i = start; i <= n; i++)
            {
                nums.Add(i);
                Loop(n, k - 1, i);
                nums.RemoveAt(nums.Count - 1);
            }
        }
    }
}
