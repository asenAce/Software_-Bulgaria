using System;
using System.Collections.Generic;
using System.Linq;
// using System.Numerids; ???
using System.Text;
using System.Threading.Tasks;

namespace _01_FibonacciNumbers
{
    class Program
    {

        //Define a method Fib(n) that calculates the nth Fibonacci number.
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number n ");
            Console.Write(" n =  ?");
            int n = int.Parse(Console.ReadLine());

            Fib(n);


           
        }
        static void Fib( int n)
        {
             BigInteger fibOne = 0;
             BigInteger fibTwo = 1;
             BigInteger sum = 0;
            

            for (int i = 0; i <= n; i ++ )
            {
                Console.WriteLine(sum);
                sum = fibOne + fibTwo;
                fibTwo = fibOne;
                fibOne = sum;

            }
            Console.ReadLine();
        }

    }
}
