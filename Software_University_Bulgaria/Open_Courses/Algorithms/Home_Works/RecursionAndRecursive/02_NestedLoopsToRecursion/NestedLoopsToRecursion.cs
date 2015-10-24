using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwo.cs
{
    using System;
    using System.Collections.Generic;

    class NestedLoopsToRecursion
    {
        static List<int> nums = new List<int>();
        private static int loops = 0;

        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Loop(n, loops);
        }

        static void Loop(int n, int loops)
        {
            if (loops == n)
            {
                Console.WriteLine(string.Join(" ", nums));
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                nums.Add(i);
                Loop(n, loops + 1);
                nums.RemoveAt(nums.Count - 1);
            }
        }
    }
}
