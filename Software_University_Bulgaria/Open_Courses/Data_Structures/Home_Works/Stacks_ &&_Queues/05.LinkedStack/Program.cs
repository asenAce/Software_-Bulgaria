using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.LinkedStack
{
    class Program
    {
        static void Main(string[] args)
        {

            var test = new Stack<int>();
            test.Push(5);
            test.Push(7);
            test.Push(9);

            Console.WriteLine(test.Pop());
            Console.WriteLine(test.Pop());
            Console.WriteLine(test.Pop());


        }
    }
}
