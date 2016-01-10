using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017.MethodsPartIII
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] someNums = { 23,32,33,44,55};
            int x;

            Console.WriteLine("\n At beginning of Main()...");

            for ( x = 0; x < someNums.Length; x++)
            {
                Console.WriteLine("{0,6}",someNums[x]);
                Console.WriteLine();
                MethodGetsArray(someNums);
                Console.WriteLine("At the end of Main() method");

                for ( x = 0; x < someNums.Length; x++)
                {
                    Console.WriteLine("{0,6}",someNums[x]);
                }
            }
        }
   
        public static void MethodGetsArray(int [] vals)
        {
            int x;
            Console.WriteLine(" in MethodGetsArray() ");

            for ( x = 0; x < vals.Length; x++)
            {
                Console.WriteLine("{0}",vals[x]);
                Console.WriteLine();
            }

            for ( x = 0; x < vals.Length; x++)
            {
                vals[x] = 888;
                Console.WriteLine("After change");
            }

            for (  x = 0; x < vals.Length; x++)
            {
                Console.WriteLine("{0}",vals[x]);
                Console.WriteLine();
            }
        }
    
    }
}
