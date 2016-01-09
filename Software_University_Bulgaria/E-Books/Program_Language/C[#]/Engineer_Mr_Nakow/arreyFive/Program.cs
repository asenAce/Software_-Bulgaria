using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreyFive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {1,2,3,4,5 };

            Console.Write("Output:  ");

            for (int index = 0; index < array.Length;index++ )
            {
                //Doubling the number
                array[index] = 2*array[index];
                //Print the number
                Console.Write(array[index] + " ");
            }



        }
    }
}
