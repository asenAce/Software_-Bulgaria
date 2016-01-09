using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forEachFour
{
    

    class PrintMax
    {
        
         
        static void PrintMax( float number1, float number2)
        {
            Console.WriteLine("Number1 = ");
           // int number2 = int.Parse(Console.ReadLine());


            float max = number1;

            if( number1 > number2)
            {
                max = number2;
            }
            Console.WriteLine(" max number is:" + max);


        }


    }
}
