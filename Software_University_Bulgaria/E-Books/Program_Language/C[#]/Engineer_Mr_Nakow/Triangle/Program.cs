using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main()
        {
            //Entering the value of the variable n 
            Console.Write(" n =  ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();


            // Print the upper part of the triangle

            for( int line = 1; line <= n ; line++)
            {
                PrintLine(1,line);
            }
            // Print the bottom part 

            for (int line = n - 1; line >= 1; line-- )
            {
                PrintLine(1,line);
            }
        }

        static void PrintLine(int start,int end) // declare the method
        {
            for (int i = start; i <= end; i++ )
            {
                Console.Write("  " + i);
            }
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
