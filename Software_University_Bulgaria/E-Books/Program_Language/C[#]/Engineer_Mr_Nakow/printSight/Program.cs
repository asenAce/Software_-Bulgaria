using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printSight
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("number =  ");
            int number = int.Parse(Console.ReadLine());

            if ( number < 0)
            {
                Console.WriteLine("Not applicable");

                if( number >0)
                {
                    Console.WriteLine("Positive");
                }

                else if ( number == 0)
                {
                    Console.WriteLine(" number = 0 ");
                }
                 
                else
                {
                    Console.WriteLine("not a number ");
                }
                Console.ReadLine();

            }
            Console.ReadLine();

        }
    }
}
