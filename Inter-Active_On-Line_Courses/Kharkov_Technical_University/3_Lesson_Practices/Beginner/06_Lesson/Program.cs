using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 123.4;
            double y = 345.6;
            var isBigger = x > y;

            bool likesBroccoli = false;
            Boolean likesChocolate = true;

            Console.WriteLine(!likesChocolate);

            //True if both operands are true,false otherwise
            bool likesBoth = likesBroccoli && likesChocolate;

            string test = likesBroccoli ? "Yes" : "No";

            //True if at least one operand is true,false otherwise.
            bool likesEither = likesBroccoli || likesChocolate;

            //True if exactly one operand is true, false otherwise.
            bool likesExactlyOne = likesBroccoli ^ likesChocolate;

            bool complicated = !likesChocolate || 10 + 20 * 30 > 40 && !likesBroccoli;

            int z = 5;
            //prints "true" if z is not five or ten, right?
            bool notFiveOrTen =(z !=5 ) &&  ( z != 10);





        }
    }
}
