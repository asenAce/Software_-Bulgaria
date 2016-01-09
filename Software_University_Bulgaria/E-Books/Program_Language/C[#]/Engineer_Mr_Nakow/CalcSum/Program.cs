using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcSum
{
    class Program
    {
        static long CalcSum( params int [] elements)
        {
            long sum = 0;
            foreach (int element in elements)
            {
                sum = sum + element;
            }
            return sum;
        }


        static void Main(string[] args)
        {

            long sum = CalcSum(2,5);
            Console.WriteLine(sum);

            long sum2 = CalcSum(4,0,-2,12);
            Console.WriteLine(sum2);

            long sum3 = CalcSum();
            Console.WriteLine(sum3);

        }
    }
}
