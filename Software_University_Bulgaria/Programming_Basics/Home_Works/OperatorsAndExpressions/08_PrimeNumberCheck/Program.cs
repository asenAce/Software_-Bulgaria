using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.PrimeNumberCheck
{
    class Program
    {
        //Write an expression that checks if given positive 
        //integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1). Examples:

        static void Main(string[] args)
        {
            Console.WriteLine("n = ?");
            int n = int.Parse(Console.ReadLine());



            if ( n == 1)
            {
                Console.WriteLine("The number is not a prime number.");
            }
            else
            {
                int primeCount= 0;
            }

            for(int i = 1 ;   i <= n; i ++)
            {
                if( n % i == 0)
                {
                    primeCount++;
                }
            }

            bool isPrime = true;

            if( primeCount >2)
            {
                isPrime = false;
            }
            Console.WriteLine("The number is prime = " + isPrime);
            Console.ReadLine();


        }
    }
}
