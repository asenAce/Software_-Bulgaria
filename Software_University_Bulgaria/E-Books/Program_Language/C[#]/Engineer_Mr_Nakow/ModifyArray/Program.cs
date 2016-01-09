using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyArray
{
    
    class Program : person
    {
        static void ModifyArray(int[] arrParam)
        {
            arrParam[0] = 5;

            Console.WriteLine("In ModifyArray()  the param is:  ");
            PrintArray(arrParam);
        }

        static void PrintArray( int [] arrParam)
        {
            Console.Write("[");
            int Length = arrParam.Length;

            if( Length >0)
            {
                Console.Write(arrParam[0].ToString ());

                for (int i = 1; i < Length; i++ )
                {
                    Console.Write(", {0}" , arrParam[i]);
                }

            }
            Console.WriteLine("]");
        }

    
 
        static void Main()
        {
            /**
            int[] arrArg = new int[] { 1,2,3};

            Console.Write("Before ModifyArray()  the argument is:  ");
            PrintArray(arrArg);

            //Modifying the array's argument
            ModifyArray(arrArg);

            Console.Write(" After ModifyArray() the argument is:  ");
            PrintArray(arrArg);
             
             **
             *
             * **/
            Console.Write("NAME = ");
            string name = Console.ReadLine();

            Console.Write("Age");
            int age = int.Parse(Console.ReadLine());
            


        }
    }
}
