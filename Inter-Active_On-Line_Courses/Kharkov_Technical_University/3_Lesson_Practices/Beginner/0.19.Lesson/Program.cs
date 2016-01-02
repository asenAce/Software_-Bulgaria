using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _0._19.Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] array = {10.0m,5.3m,100.4m };
            decimal maximum = Program.Maximum(array);

            TestMaximum();

        }

        static decimal Maximum(decimal[] values)
        {
            /**
             * exception  syntax
             * 
             * throw expression;
             * 
             * new SomeException(arguments)
             * */

            if (values.Length == 0)
            {
                throw new ArgumentException("Array can not be empty","values");
            }
            if (values == null)
            {
                throw new ArgumentNullException("values","Array cannot be null");
            }

            decimal biggestSoFar = 0.0m;
            foreach (decimal item in values)
            {
                if (item > biggestSoFar)
                {
                    biggestSoFar = item;
                }
            }
            return biggestSoFar;

            //TODO 
            //  return 123.4m;
        }

      static void TestMaximum()
        {
            decimal[] onePositive = { 123.4m };
            decimal[] oneNegative = { -456.7m};
            decimal[] oneZero = { 0.0m };

            decimal[] tenAscendingNoDuplicatesPositive = { 1.2m,2.3m,3.4m,4.5m,5.6m,6.7m,7.8m,8.9m,9.10m,10.11m};
         
            VerifyTest(Maximum(onePositive),123.4m,"one positive");
            VerifyTest(Maximum(oneNegative),-456.7m,"one negative");
            VerifyTest(Maximum(oneZero),0.0m,"one zero");
            VerifyTest(Maximum(tenAscendingNoDuplicatesPositive),10.11m,"ten Ascending No Duplicates Positive");

          /**
            if (Maximum(onePositive) == 123.4m)
            {
                Console.WriteLine("one positive PASSED");
            }
            else
            {
                Console.WriteLine("one positive FAILED");
            }
           * i can create a Method
          **/  

           }

      static void VerifyTest(decimal observed,decimal expected,string name)
      {
          if (expected == observed)
          {
              Console.WriteLine(('$')("{name} PASSED");
              
          }
          else
        	{
              Console.WriteLine('$'"{name} FAILED - observed {observed},expected {expected}");
        	}

      }

    }
}
