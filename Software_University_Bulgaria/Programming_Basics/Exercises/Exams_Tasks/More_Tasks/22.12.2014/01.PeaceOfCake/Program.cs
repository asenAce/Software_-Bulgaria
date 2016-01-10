using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PeaceOfCake
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal numberA = decimal.Parse(Console.ReadLine());
            decimal numberB = decimal.Parse(Console.ReadLine());
            decimal numberC = decimal.Parse(Console.ReadLine());
            decimal numberD = decimal.Parse(Console.ReadLine());

            decimal total = (numberA / numberB) + (numberC / numberD);

            if (total >=1)
            {
                Console.WriteLine(Math.Floor(total));
            }
            else
            {
                Console.WriteLine("{0:F22}",total);
            }
            decimal denominator = numberB* numberD;
            numberA = numberA * (denominator/numberB);
            numberC = numberC * (denominator / numberD);

            Console.WriteLine("{0}/{1}",numberA + numberC);

        }
    }
}
 