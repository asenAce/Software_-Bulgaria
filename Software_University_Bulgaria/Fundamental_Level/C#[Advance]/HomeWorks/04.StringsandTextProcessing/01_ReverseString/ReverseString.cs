using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndTextProcessing.cs
{
    class ReverseString
    {
        /*
         * Reverse String 
         * */

        static void Main(string[] args)
        {
            Console.WriteLine("Give me your string ");
            string input = Console.ReadLine();
            Console.WriteLine(Reverse(input));

             
        }

        // Method

        public static string Reverse(string x)   
        {
            StringBuilder sb = new StringBuilder();

            int lenght = x.Length - 1;

            for (int i = lenght; i >= 0; i--)
            {
                sb.Append(x[i]);
            }

            return sb.ToString();
        }


    }
}
