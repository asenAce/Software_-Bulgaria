using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraySeven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1,2,3,4,5};

            Console.Write("Reversed:  ");

            for (int index = array.Length - 1; index >= 0;index-- )
            {
                Console.Write(array[index] + "");
            }

            //The result = 5>4>3>2>1

        }
    }
}
