using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masivesOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayReverseExample

            int[] array = {1,2,3,4,5 };
            //Get array size.
            int length = array.Length; //This is the size of the array;
            //Declare and create the reversed array.
            int[] reversed = new int[length];


            //Initialize the reversed array.

            for (int index = 0; index < length;index++ )
            {
                reversed[length - index-1]=array[index];
            }
            //Print the reversed array
            for (int index = 0; index < length;index++ )
            {
                Console.Write(reversed[index]+  "  ");
            }
        }
    }
}
