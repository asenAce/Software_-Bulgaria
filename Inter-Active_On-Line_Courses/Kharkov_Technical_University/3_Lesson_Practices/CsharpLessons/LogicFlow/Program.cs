using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyndaLessons
{
    class Program
    {
#region 
        
        static void Main(string[] args)
        {

            //While loops

            //int sentinel = 5;
            //while (sentinel <10)
            //{
            //    Console.WriteLine(sentinel);
                //sentinel++;
                //Console.Read();
            //}

       // If statement

            bool result = true;
            if (result)     //Cheacking for a 
            {
                Console.WriteLine("result was true");
            }
            else
            {
                Console.WriteLine("result was false");
                Console.Read();
            }

            //if...else if
            int value = 0;
            if (value == 0)
            {
                Console.WriteLine("Value is 0");
            }
            else if (value == 1)
            {
                Console.WriteLine("Value is not a 0");
            }
            else
            {
                Console.WriteLine("Value is something else");
                Console.Read();
            }
            //The switch statement
            int valueA = 2;

            switch(valueA)
            {
                case 0:
                    Console.WriteLine("ValueA is 0");
                    break;
                case 1:
                    Console.WriteLine("ValueA is 1");
                    break;
                
                default:
                    Console.WriteLine("ValueA is something else");
                    Console.Read();
                    break;

            }
#endregion 
        }

    }

}
