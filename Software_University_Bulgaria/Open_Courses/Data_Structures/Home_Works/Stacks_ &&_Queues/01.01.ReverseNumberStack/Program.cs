using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._01.ReverseNumberStack
{
    class Program
    {
        static void Main(string[] args)
        {
            #region The Input
            Console.WriteLine("Please , input N ... ");
            int numberOfIntegers = int.Parse(Console.ReadLine());

            // Creating a Stack<>

            Stack<int> stack = new Stack<int>();

            #endregion The Input
            #region The Logic
            while (numberOfIntegers > 0)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                // stack is an Object and .Push is a Method which add data to the Stack<>  () parameters in this case
                // i am passing a data to the parameters (currentNumber);
                stack.Push(currentNumber);
                numberOfIntegers--;
            }

            Console.WriteLine();
            while (stack.Count > 0 )
            {
                Console.WriteLine(stack.Pop());
            }
            #endregion The Logic
        }
    }
}
