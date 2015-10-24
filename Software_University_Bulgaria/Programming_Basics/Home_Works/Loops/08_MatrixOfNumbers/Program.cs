using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task08.MatrixOfNumbers
{

    /*
     *Write a program that reads from the console a positive integer number
     *n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.  
     * */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Positive integer number n (1 <= n <= 20): ");
            int num = int.Parse(Console.ReadLine());

            if (num <0)
            {
                Console.WriteLine("n is not a possitive number! ");
            }

            for (int row = 0; row < num;row++ )
            {
                for (int col = 1; col <= num;col++ )
                {
                    Console.WriteLine("{0,-3}",row + col);
                }
            }
            Console.ReadLine();
            

        }
    }
}
