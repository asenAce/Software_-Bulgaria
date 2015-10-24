using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task010.RandomNumbersInGivenRange
{
    /**
     * Write a program that enters 3 integers n, min and max 
     * (min ≤ max) and prints n random numbers in the range [min...max].
     * */

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("  min =  ");
            int min = int.Parse(Console.ReadLine());

            Console.Write(" max =  ");
            int max = int.Parse(Console.ReadLine());

            if   ( min > max)
            {
                Console.WriteLine(" min can not be bigger than max !");
                Console.ReadLine();
            }
            

            if( min < max)
            {
                Random random = new Random(); // ?? What is this am i creating a new object called Random?
                  
            
            Console.ReadLine();
                for (int i = 0; i < n; i++ )
                {
                    /**
                     * Object random has method /haracteristic /.Next () this is parameters in this case min and max,max increments by 1 + add " "
                     * empry space!
                     * */
                    Console.Write(random.Next(min,max + 1) + " ");
                }
                Console.WriteLine();
                Console.ReadLine();

                
            }
            else
            {
                Console.WriteLine(" min can not be equal to max");
            }
            Console.ReadLine();
            


        }


    }
}
