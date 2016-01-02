using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16.Lesson.DeeperLookatEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            // Compare integers

            int two = 2;
            int sum = two + two;
            bool compareIntegers = (sum == 4);

            //Compare strings.

            string hello = "hello";
            string concatenation = hello + hello;
            bool compareStrings = (concatenation == "hellohello");

            // arrays?

            int[] abc = { 10,20,30};
            int[] def = abc;
            bool compareArraysOne = (abc == def);

            int[] ghi = { 10,20,30};


        
        
        }
    }
}
