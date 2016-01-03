using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._1SumAndAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            //The Input
            List<int> list = new List<int>();
            string input = Console.ReadLine();

            //The Logic
            input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(el => list.Add(int.Parse(el)));

           // BigInteger sum = list.Sum();
            double average = list.Average();
          //  Console.WriteLine("Sum: {0}\tAverage: {1:0.000}",sum,average);

          //The Output




        }
    }
}
