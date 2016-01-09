using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17.Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //We saw earlier:
            int[] abc = { 10,20,30};
            abc = new int[] { 10,20,30};
            
            int intElement = abc[0];


            string[] def = new string[3];
            string stringElement = def[0];

            bool[] ghi = new bool[3];
            bool boolElement = ghi[0];

            string allBools = string.Join(" - ",ghi);



        }
    }
}
