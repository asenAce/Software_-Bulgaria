using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Compare this:

            int numberWhile = 1;

            while (numberWhile <10)
            {
                Console.WriteLine(numberWhile);
                numberWhile = numberWhile + 1;
            }
            //to this:

            int numberDo = 1;
            do
            {
                Console.WriteLine(numberDo);
                numberDo = numberDo + 1;
            } while (numberDo < 10 );


            /**
             * What if the condition is never met?
             * Compare this:
             * */

            int max = 1;
            numberWhile = 1;

            while (numberWhile < max)
            {
                Console.WriteLine(numberWhile);
                numberWhile = numberWhile + 1;
            }

            // this:

            do
            {
                Console.WriteLine(numberDo);
                numberDo = numberDo + 1;
            } while (numberDo < max);

            /**
             * Common workflow:
             * 
             * 1.Try to do something
             * 2.Did you succeed?Then  we are done.
             * 3.Attempt to fix the problem that led to failure.
             * 4.Go back to 1.
             * How would we write this as a loop?
             * 
             * examp.
             * 
             * bool succeeded = false;
             * while(!succeeded)
             * {
             *      succeeded = TryToDoSomething();
             *      if(!succeeded)
             *      {
             *          TryToFixIt();
             *      }
             * }
             * 
             * Alternativily
             * 
             * while()
             * {
             *      bool succeeded = TryToDoSomething();
             *      if(succeeded)
             *          break;
             *          TryToFixIy();
             * }
             * 
             * */

            //Using continue

            for (int number = 0; number < 20; number+=1)
            {
                if (number % 7 !=0)
                {
                    Console.WriteLine(number);
                }
            }

            for (int number = 0; number < 20; number+=1)
            { 
                if (number % 7 == 0)
                {
                    continue;
                    Console.WriteLine(number);
                }
            }

            // nested

            for (int number = 1; number <= 10 ; number+=1)
            {
                for (int numberTwo = 1; numberTwo <= 10 ; numberTwo+=1)
                {
                    Console.WriteLine(numberTwo);
                }
            }

            //nested two

            for (int x = 0; x <= 10; x+=1)
            {
                for (int y = 1; y <= 10; y+=1)
                {
                //    Console.WriteLine($"{x},{y}");
                }
            }

            // Loop variables need not be integers

            var today = DateTime.Now.Date;
            var nextMonth = today.AddMonths(1);

            for (var date = today; date <= nextMonth; date = date.AddDays(1))
            {
                Console.WriteLine(date);
            }



        }
    }
}
