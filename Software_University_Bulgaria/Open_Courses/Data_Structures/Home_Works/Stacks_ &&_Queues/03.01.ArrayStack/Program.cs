using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._01.ArrayStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new ArrayStack<int>();
            int[] arrOne = stack.ToArray();
            Console.WriteLine(string.Join(", ",arrOne));
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Count);

            int[] arr = stack.ToArray();
            Console.WriteLine(string.Join(", ",arr));
            var stackOne = new ArrayStack<int>();
            var st = new Stack<int>();

        }
    }
}
