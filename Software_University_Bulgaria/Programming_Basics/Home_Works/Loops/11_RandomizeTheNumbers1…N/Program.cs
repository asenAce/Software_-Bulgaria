using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task011.RandomizeTheNumbers1_N
{
    /**
     * Write a program that 
     * enters in integer n and prints the numbers 1, 2, …, n in random order. 
     * */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" n = ");
            int n = int.Parse(Console.ReadLine());

            Random randomNumbers = new Random();

            for (int i = 1; i <= n; i ++ )
            {
                Console.WriteLine(randomNumbers.Next(1,n + 1)+ "  ");
            }

            Console.WriteLine();
            Console.ReadLine();


        }
    }
}
