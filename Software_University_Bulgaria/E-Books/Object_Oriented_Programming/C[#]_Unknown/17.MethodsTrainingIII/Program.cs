using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017.MethodsTrainningIII
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] someNumbers = { 3434,3434,34,345};
            int x;

            Console.WriteLine("At the beginning of the main()");

            for ( x = 0; x < someNumbers.Length; x++)
            {
                Console.WriteLine("{0,6}",someNumbers[x]);
                Console.WriteLine();
            }

            MethodGetArray(someNumbers);
            Console.WriteLine("At the end of the Main()");

            for (  x = 0; x  < someNumbers.Length; x++)
            {
                Console.WriteLine("{0,6}",someNumbers[x]);
            }
             


        }


        public static void MethodGetArray(int[] vals)
        {
            int x;
            Console.WriteLine("In MethodGetArray()");

            for (  x = 0; x < vals.Length; x++)
            {
                Console.WriteLine("{0}",vals[x]);
                Console.WriteLine(); 
            }
            for ( x = 0; x < vals.Length; x++)
            {
                Console.WriteLine("{0}",vals[x]);
            }
            vals[x] = 888;

            for (  x = 0; x < vals.Length; x++)
            {
                Console.WriteLine("After the changes {0}",vals[x]);
                Console.WriteLine();
            }


        }
    }



}
