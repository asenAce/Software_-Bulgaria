using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._15.Lesson.Types_and_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int abc = 1;
            int def = abc;
            abc = 2;

            //Variables are still not aliases
            int[] ghi = new int[] { 10};
            int[] jkl = ghi;
            ghi = new int[] { 20 };

            //But two variables can refer  to the same array
            ghi = new int[] { 10 };
            jkl = ghi;
            ghi[0] = 20;

            // what about strings?
            string qrs = "hello";
            string tuv = qrs;
            qrs = "goodbye";

            //That showed nothing.
            qrs = "Hello";
            tuv = qrs;

            // the null reference is the reference that  refers to nothing
            qrs = null;
            Console.WriteLine(qrs.Length);

        }
    }
}
