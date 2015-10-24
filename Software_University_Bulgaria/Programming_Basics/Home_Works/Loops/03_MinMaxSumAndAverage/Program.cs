using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task03.MinMaxSumAndAverageOfNNumbers
{
    class Program
    {

        /**
         * Write a program that reads from the console a sequence of n integer numbers and returns the minimal,
         * the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). The input starts by the number n (alone in a line)
         * followed by n lines, each holding an integer number. The output is like in the examples below
         * 
         * **/
        static void Main(string[] args)
        {

            
            Console.WriteLine("Enter sequence of n int numbers:  ");
            int sequence = int.Parse(Console.ReadLine());

            Console.WriteLine("number = ");
            int number = int.Parse(Console.ReadLine());

            int min = int.MinValue;
            int max = int.MaxValue;
           // int round= int.
            double sum = 0;
            double avg = 0;
           // int round;
            
            if ( sequence<0 || number <0)
            {
                Console.WriteLine("Only possitive thinking, only possitive ;-)");
                Console.ReadLine();
                return;
            }


            for (int i = 0; i < sequence;i++ )
            {
                

                //min
                min = Math.Min(number,sequence);

                //round = Math.Round(number,sequence);
                //max
                max = Math.Max(number,sequence);
                //sum
                sum =sequence + number;

                //avg
                avg = sum / 2;
            }

            Console.WriteLine("Min = "+min);
            Console.WriteLine("Max = "+max);
            Console.WriteLine("Sum = "+sum);
            Console.WriteLine("Avg = {0:F2}",avg);
            Console.ReadLine();
        }
    }
}
