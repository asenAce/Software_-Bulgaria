using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SortWords
{
    class SortWords
    {
        static void Main(string[] args)
        {
            //The Input
            var line = Console.ReadLine().Split().ToList();
            //The Logic
            var sorted = line.OrderBy(word => word);
            //The Output
            Console.WriteLine(String.Join(" ",sorted));



        }
    }
}
