using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task06.Calculate_N_K
{

    /**
     * Write a program that calculates 
     * n! / k! for given n and k (1 < k < n < 100). Use only one loop. 
     * */


    class Program
    {
        static void Main()
        {
            Console.Write("Positive int > 0 and < 100: ");
            double n = double.Parse(Console.ReadLine());
            Console.Write("Positive int > 0 and < N: ");
            double k = double.Parse(Console.ReadLine());

            double factorialN = 1;
            double factorialK = 1;

            for (int i = 1; i <= n; i++)
            {
                if (i <= k)
                {
                    factorialK *= i;
                }
                factorialN *= i;
            }

            Console.WriteLine(factorialN / factorialK);
            Console.ReadLine();
        }
    }
}
    

