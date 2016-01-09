using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._01.LinkedStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new LinkedStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            var arr = stack.ToArray();
            Console.WriteLine(string.Join(", ", arr));
            var stack1 =new LinkedStack<int>();
        }
    }
}
