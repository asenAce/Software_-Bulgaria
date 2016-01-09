using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileSimpleNumberN
{
    class Program
    {
        //A simple number can divided on it's self and 1
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a possitive number:  ");
            int num = int.Parse(Console.ReadLine());
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(num);
            bool prime = true;
    
            while( prime && (divider <= maxDivider))
            {
                if( num % divider == 0 )
                {
                    prime = false;
                }
                divider++;
            }
            Console.WriteLine("Prime?  " + prime);
            Console.ReadLine();
        }
    }
}

