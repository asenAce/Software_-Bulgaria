using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._1.Lesson
{
    class Program
    {


        List<int> Primes(int last)
        {
            if (last < 2)
            {
                return new List<int>();              
            }

            List<int> primes = new List<int>() { 2 };


            for (int number = 2; number <= last; number++)
            {
                bool isPrime = true;
                foreach (var prime in primes)
                {
                    if (number % prime == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    primes.Add(number);
                }


                return primes;
            }
            return primes;
        }


        static void Main(string[] args)
        {




        }
    }
}
