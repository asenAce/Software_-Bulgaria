using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ArrayBasedStack
{
    class Program  //main
    {
        static void Main(string[] args)
        {
            var test = new ArrayStack<int>();
            test.Push(5);
            test.Push(7);
            test.Push(9);

            Console.WriteLine(test.Pop());
            Console.WriteLine(test.Pop());
            Console.WriteLine(test.Pop());


        }
    }
}
