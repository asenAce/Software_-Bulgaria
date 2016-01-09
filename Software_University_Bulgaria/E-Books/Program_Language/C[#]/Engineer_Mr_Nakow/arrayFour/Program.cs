using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayFour
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = {"one","two","three","asen" };

            for (int index = 0; index < array.Length; index ++ )
            {
                //Print each element on a separate line
                Console.WriteLine("Element [{0}] = {1}",index,array[index]);
            }
            Console.ReadLine();


        }
    }
}
