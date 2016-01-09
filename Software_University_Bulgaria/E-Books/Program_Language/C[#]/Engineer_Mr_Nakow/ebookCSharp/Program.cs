using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebookCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare some variables:
            byte centuries = 20;
            ushort years = 2000;
            uint days = 730480;
            ulong hours = 17531520;

            //Print the result on the console.
            Console.WriteLine(centuries + " centuries are " + years + "the years are " + days + " days , or" + hours + "housre.");


            //Console output :
            //20 Centuries are 2000 years,or 730480 days , or 17531520 hours.

            ulong maxIntValue = UInt64.MaxValue;
            Console.WriteLine(maxIntValue); //18828....
            Console.Read();


        }
    }
}
