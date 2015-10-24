using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PrimeInRangeThree
{
    class PrimesInRange
    {
        static List<int> FindPrimes(int startNum, int endNum)
        {
            List<int> primesCollection = new List<int>();

            if (startNum < 2)
            {
                startNum = 2;
            }

            for (int i = startNum; i <= endNum; i++)
            {
                int divider = 2;
                double maxDivider = Math.Sqrt(i);
                bool isPrime = true;

                while (divider <= maxDivider)
                {
                    if (i % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }

                    divider++;
                }

                if (isPrime)
                {
                    primesCollection.Add(i);
                }
            }

            return primesCollection;
        }

        static void Main()
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            if (startNum > endNum)
            {
                Console.WriteLine("(empty list)");
            }
            else
            {
                List<int> primes = FindPrimes(startNum, endNum);

                for (int i = 0; i < primes.Count; i++)
                {
                    if (i < primes.Count - 1)
                    {
                        Console.Write(primes[i] + ", ");
                    }
                    else
                    {
                        Console.WriteLine(primes[i]);
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}
