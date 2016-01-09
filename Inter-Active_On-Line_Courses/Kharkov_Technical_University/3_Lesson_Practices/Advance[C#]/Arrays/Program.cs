using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numbers = new int[10];
            // Allocating an array of 10 integers:
            // int [] number = new int [10];
            // type . [] id = new /operator new/ int [10];
            // int [] number = new int [10];
            // double [] streets = new double[15];

            //Assigning values to the array elements:
            for (int i = 0; i < numbers.Length; i ++ )
            {
                numbers[i] = i + 1;
            }

            // Accessing array elements by index:
            numbers[3] = 20;
            numbers[4] = 12;
            numbers[5] = 22;

            numbers[6] = ((numbers[3] + numbers[4] ) / ( numbers [4]  - numbers[3])*6);
            //Console.WriteLine(numbers[6]);
            //Console.ReadLine();


            //Print the array
            for (int i = 0; i < numbers.Length; i ++ )
            {
                Console.WriteLine( "numbers[{0}]  = {1}" , i, numbers[i] );
            }

            // Manipulations of the array
            Console.WriteLine("Sum = " + numbers.Sum());
            Console.WriteLine("Min = " + numbers.Min());
            Console.WriteLine("Max = " + numbers.Max());
            Console.WriteLine("First =   " + numbers.First());
            Console.WriteLine("Last = " + numbers.Last());
        }
    }
}
