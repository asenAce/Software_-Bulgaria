using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Lesson.SimpleStack
{
    class Program
    {
        static void Main(string[] args)
        {
                // Stack One <> ID values
            Stack<int> values = new Stack<int>();

            values.Push(10);
            values.Push(20);

            int twenty = values.Pop();
            int ten = values.Pop();

                // Stack One <> ID secondValues
            Stack<int> secondValues = new Stack<int>();
           
            secondValues.Push(30);
            secondValues.Push(40);

            int thirthy = secondValues.Pop();
            int fourty = secondValues.Pop();
            

            foreach (var TheValue in values)
            {
                Console.WriteLine(TheValue);

                if (TheValue == 0)
                {
                    Console.WriteLine("Stack can not be empty");
                }

                else
                {
                    Console.WriteLine("{0}",secondValues);
                }
            }

        }
    }
}
