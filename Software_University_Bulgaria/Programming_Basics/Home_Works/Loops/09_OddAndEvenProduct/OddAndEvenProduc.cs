using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task09.OddAndEvenProduct
{

    /**
     * You are given n integers (given in a single line, separated by a space). Write a program that checks 
     * whether the product of the odd elements is equal to the product of the even elements. 
     * Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
     * */
    class OddAndEvenProduc
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insert n integers given in a single line, separated by a space:");
            string[] nums = Console.ReadLine().Split();


            int oddsSum = 1;
            int evenSum = 1;


            for (int i = 0; i < nums.Length;i++ )
            {
                int currNum = int.Parse(nums[i]);

                if( i % 2 == 0)
                {
                    oddsSum = oddsSum * currNum; // odd
                }

                else
                {
                    evenSum = evenSum * currNum; // for even
                }
            }
            if( oddsSum == evenSum)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = {0}",oddsSum);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = {0}",oddsSum);
                Console.WriteLine("even_product = {0}",evenSum);
            }
            Console.ReadLine();
        
        }
    }
}
