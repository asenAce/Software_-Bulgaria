using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseNumberStack
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Input Data

            string input = Console.ReadLine();

            #endregion Input Data
            #region The Logic
            if (!string.IsNullOrEmpty(input))
            {

                // Creating  a massive object input. method Split () passing parameters (' ')
                string[] nums = input.Split(' ');
                //Creatin a stack ID stack <TYPE> string 
                var stack = new Stack<string>();

                for (int i = 0; i < nums.Length; i++)
                {   // .Push add nums [i] possition
                    stack.Push(nums[i]);
                }

                for (int i = 0; i < nums.Length; i++)
                {   // .Pop method
                    Console.WriteLine(stack.Pop());
                }

            }

            else
            {
                Console.WriteLine("(empty)");
            }

            #endregion The Logic
        }
    }
}
