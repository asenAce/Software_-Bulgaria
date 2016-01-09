using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LinkedQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Queue<int>();
            test.Enqueue(5);
            test.Enqueue(8);
            test.Enqueue(7);

            Console.WriteLine(test.Dequeue());
            Console.WriteLine(test.Dequeue());
            Console.WriteLine(test.Dequeue());
            Console.WriteLine();

            int[] arr = test.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            

        }
    }
}
