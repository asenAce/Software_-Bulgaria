using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017.MethodsPartII
{
    class Program
    {
        static void Main(string[] args)
        {
            int []   someNumbers = {33,22,44,55,66};
            int x;

            Console.WriteLine("\nAt beginning of Main() method...");

            for ( x = 0; x < someNumbers.Length; x++)
            {
                 Console.WriteLine("{0,6}",someNumbers[x]);
                 Console.WriteLine();
            }

            for ( x = 0; x < someNumbers.Length; x++)
            {
                MethodGetOneInt(someNumbers[x]);
                Console.WriteLine("At end of Maing() method..........");
            }
            for ( x = 0; x < someNumbers.Length; x++)
            {
                Console.WriteLine("{0,6}",someNumbers[x]);
            }
        }

        public static void MethodGetOneInt(int oneVal)
        {
            Console.WriteLine("In MethodGetOneInt() {0}",oneVal);
            oneVal = 999;
            Console.WriteLine("  After change {0}",oneVal);
        }

    }
}
