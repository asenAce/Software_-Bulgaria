using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015.Lesson
{
    class Program
    {
        // Reverse()

        static void Main(string[] args)
        {
            string[] names = { "Zag","zig","Wnddy","Bendy"};
            int x;
            Array.Reverse(names);

            for ( x = 0; x < names.Length; x++)
            {
                Console.WriteLine(names[x]);
            }
        }
    }
}
