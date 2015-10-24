using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortingNumbersTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++ )
            {
                int num = int.Parse(Console.ReadLine());
                numbers.Add(num);
            }
            numbers.Sort();
            Console.WriteLine();

            foreach ( var number in numbers)
            {
                Console.WriteLine("{0}",number);
            }
            Console.ReadLine();
        }
    }
}
