using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011.BitwiseExtractBit__3
{
    class Program
    {
        /**
         * Using bitwise operators, write an expression for finding
         * the value of the bit #3 of a given unsigned integer. The bits are counted from right
         * to left, starting from bit #0. The result of the expression should be either 1 or 0. 
         * 
         * **/
        static void Main(string[] args)
        {
            Console.Write(" Enter your  number:  ");
            int number = int.Parse(Console.ReadLine());

            int fakeBit = 1 << 3;
            int foundBit = number & fakeBit;

            if( foundBit == 0)
            {
                Console.WriteLine("Third bit is '0' " + Convert.ToString(number,2).PadLeft(16,'0'));
            }
            
            else
            {
                Console.WriteLine("Third bit is '1' " + Convert.ToString(number,2).PadLeft(16,'0'));
            }
            Console.ReadLine();

        }
    }
}
