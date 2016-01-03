using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._2.SumAndAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Input
            string input = Console.ReadLine();
            int sum = 0;
            double average = 0;

            //The Logic
            if (!string.IsNullOrWhiteSpace(input))
            {
                List<int> numbers = input.Split(' ').Select(s => int.Parse(s)).ToList<int>();
                sum = numbers.Sum();
                average = sum / (double)numbers.Count;
            }
            //The Output
            Console.WriteLine("Sum : {0} ; Average : {1} ",sum,average );
        }
    }
}
