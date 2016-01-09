using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typeDataConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            long myLong = long.MaxValue;
            int myInt = (int)myLong;

            Console.WriteLine(myLong);  // 92233..
            Console.WriteLine(myInt);   //-1

            float heightInMeters = 1.74f;    // Explicit conversion
            double maxHeight = heightInMeters; // Implicit
            double minHeight = (double)heightInMeters;  //Explicit
            float actualHeight = (float)maxHeight;  //Explicit

           // float maxHeightFloat = maxHeight;   // Compilation error!
            // Exception for error OverflowException.

            double d = 5e9d;    // 5 * 10^9
            Console.WriteLine(d);   //500000000
            int i = checked((int)d);
            Console.WriteLine(i);




        }
    }
}
