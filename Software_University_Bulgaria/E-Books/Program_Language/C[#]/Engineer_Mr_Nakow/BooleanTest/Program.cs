using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            //Whic one is greater?

            bool greaterAB = (a > b);

            //Ia 'a' equal to 1?
            bool equalA1 = (a == b);

            //Print the result on the Console
            if(greaterAB)
            {
                Console.WriteLine("A>B");
            }
            else  
            {
                Console.WriteLine("A<=B");
            }

            Console.WriteLine(" greaterAB = " + greaterAB);
            Console.WriteLine("equalA1 =  " + equalA1 );
        }
    }
}
