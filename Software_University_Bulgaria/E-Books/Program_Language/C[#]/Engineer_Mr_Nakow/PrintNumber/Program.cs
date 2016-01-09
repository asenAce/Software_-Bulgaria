using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumber
{
    class Program
    {
        static void PrintNumber(int numberParam)
        {
            //Modifying the primitive-type parameter
            numberParam = 5;

            Console.WriteLine("in Parameter() method ,after the " + "modification,numberParam is {0}:",numberParam);

        }


        static void Main(string[] args)
        {

            int numberArg = 3;

            /**
             * Copying the value 3 of the argument numberArg to the parameter numberParam.
             * */
            PrintNumber(numberArg);
            Console.WriteLine(" in the Main()  method number is:  " + numberArg);
            Console.ReadLine();
        }
        
    }

}
