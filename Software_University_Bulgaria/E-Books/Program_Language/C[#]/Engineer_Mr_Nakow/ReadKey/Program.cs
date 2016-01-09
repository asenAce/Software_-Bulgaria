using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadKey
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Character entered:  " + key.KeyChar);
            Console.WriteLine("Special keys:  " + key.Modifiers);
            Console.Read();


        }
    }
}
