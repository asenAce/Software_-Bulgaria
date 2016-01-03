
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LessonPrimesInARange
{
    class PrimesInRange
    {
        //01.Lesson PrimesInAnInterval

       static List<int> PrimesInRange( int first,int last)
        {
            List<int> primes = new List<int>();



            List<int> helperPrimes = new List<int>();

            for (int number = first; number <= last; number++)
            {
                var maxDivider = Math.Sqrt(number);
                bool isPrime = true;


         //        List<int> helperPrimes = new List<int>();



         //       for (int divider = 2; divider <= maxDivider; divider++)
         //       {
         //           if (number % divider == 0)
         //           {
         //               isPrime = false;
         //               break;              
         //            }
         //       }

                if (isPrime)
                {
                    primes.Add(number);
                }
            }

            return primes;
        }

        static void Main(string[] args)

        {
            Console.WriteLine(String.Join(",",PrimesInRange(1,100)));  // "" separator


        }
    }
}
