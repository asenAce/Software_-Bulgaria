using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // Even more verbose
            int count = 10;

            while (count > 0)
            {
                Console.WriteLine(count);
               // count = count - 1;
                count--;
            }
            Console.WriteLine("BlastOff!");

        }
    }
}
