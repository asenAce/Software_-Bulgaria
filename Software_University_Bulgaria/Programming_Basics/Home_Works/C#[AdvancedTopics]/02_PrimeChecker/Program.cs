using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Write a Boolean method IsPrime(n) that check whether a 
             * given integer number n is prime. 
             * */

            Console.WriteLine(" Enter number for n ");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            bool isPrime = true;
            Console.WriteLine("The number {0} is {1}",n,isPrimeNumber(n,isPrime));


        }

        static bool isPrimeNumber( int n,bool isPrime)
        {
            if( n == 0 || n ==1 || 0>n)
            {
                isPrime = false;
                return isPrime;
            }

            int counter = 0;

            for (int i = 1; i <= n; i++ )
            {
                if( n % i == 0)
                {
                    counter++;
                }
            }

            if( counter >2)
            {
                isPrime = false;
                return isPrime;
            }

            isPrime = true;
            return isPrime;


            Console.ReadLine();
        }

        
    }
}
