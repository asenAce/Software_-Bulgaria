
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Lesson_PrimesInAnInterval
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static List<int> FindPrimes(int start, int end)
        {
            List<int> primesList = new List<int>();

            for (int num = start; num <= end; num++)
            {
                bool prime = true;
                for (int div = 2; div <= Math.Sqrt(num); div++)
                {
                    if (num % div == 0)
                    {
                        prime = false;
                        break;
                    }
                    
                }

                if (prime)
                {
                    primesList.Add(num);
                }
                
            }

            return primesList;
        }
    }
}
