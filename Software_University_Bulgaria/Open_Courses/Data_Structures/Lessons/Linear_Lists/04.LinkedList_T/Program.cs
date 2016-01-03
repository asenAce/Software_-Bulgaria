using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LinkedList_T
{
    class Program
    {
        //04.LinkedList_T

        static void Main(string[] args)
        {
            var list = new LinkedList<string>();

            list.AddFirst("First");
            list.AddLast("Last");
            list.AddAfter(list.First,"After First");
            list.AddBefore(list.Last,"Before Last");


            Console.WriteLine(String.Join(",",list));

            // Result: First,After First,Before Last ,Last

            LinkedList<int> primes = new LinkedList<int>();

            primes.AddFirst(1);
            primes.AddLast(3);
            primes.AddFirst(12);

            var elementIwantToAddAfter = primes.First;

            primes.AddAfter(elementIwantToAddAfter,7);

            foreach (var prime in primes)
            {
                Console.WriteLine(prime);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

     //       list.OrderBy((v) => v % 3);

        }
    }
}
