using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOne.cs
{
    class TowerOfHanoi
    {
        private static int steps = 0;

        static void Main()
        {
            Console.Write("Insert n = ");
            int numOfDisks = int.Parse(Console.ReadLine());
            Stack<int> source = new Stack<int>(Enumerable.Range(1, numOfDisks).Reverse());
            Stack<int> spare = new Stack<int>();
            Stack<int> destination = new Stack<int>();

            MoveDisks(numOfDisks, source, destination, spare);

            Console.WriteLine("Finished in {0} steps", steps);
        }

        static void MoveDisks(int bottomDisk, Stack<int> source, Stack<int> destination, Stack<int> spare)
        {
            if (bottomDisk == 1)
            {
                steps++;
                destination.Push(source.Pop());
            }
            else
            {
                MoveDisks(bottomDisk - 1, source, spare, destination);
                destination.Push(source.Pop());
                MoveDisks(bottomDisk - 1, spare, destination, source);
            }
        }
    }
}
