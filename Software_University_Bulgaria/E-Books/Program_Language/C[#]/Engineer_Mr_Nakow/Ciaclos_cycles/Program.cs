using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciaclos_cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            //While {} cycle

            //Initialize the counter
            int counter = 0;
            //Execute the loop body while the loop condition holds
            while ( counter <= 9) 
            {
                //Print the counter value
                Console.WriteLine("Number:  " + counter);
                //Increment the counter
                counter++;
            }



        }
    }
}
