using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TaskSumAndAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Input

            // Creating a List with type <int> with ID theNumbers
            List<int> theNumbers = new List<int>();
            // Reading from the.Console var - variable line
            var line = Console.ReadLine();

            // The Logic
            //if loop (condition ! not a )

            if (!String.IsNullOrWhiteSpace(line))
            {
                // This is how the list theNumberstook value from the line with the method .Split() 
                // .Select(int.Parse) what this method do? and this .ToList();
                theNumbers = line.Split().Select(int.Parse).ToList();
            }

            else
            {
                theNumbers.Add(0);
            }

            // the Output

            Console.Clear();
            // theNumbers is an object and .Sum is a method with empty parameters();
            //{0} a place holder ,
            Console.WriteLine("Sum: {0}",theNumbers.Sum());
            Console.WriteLine("Average: {0}",theNumbers.Average());
            Console.WriteLine("Min : {0}",theNumbers.Min());
            Console.WriteLine("Max : {0}",theNumbers.Max());




        }
    }
}
