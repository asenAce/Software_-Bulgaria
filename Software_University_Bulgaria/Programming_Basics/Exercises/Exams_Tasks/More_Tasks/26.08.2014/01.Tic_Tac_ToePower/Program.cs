using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Tic_Tac_ToePower
{
    /**
     * like the one the right. As inputs you will be given the X and Y coordinates of one of the cells. Each of the cells in the field has an index and a value (look at the examples on the right). You will be given the value of the first cell V (index1). Each of the next cells will have value greater by 1 than the previous. Example: if value=80, then index1=80, index2=81, index3=82, ..., index9=89. Your task is to print on the console the value of the cell C raised to the power of its index: C index. Look at comments in the examples below to understand your task better.
Input
The input data should be read from the console.
⦁	At the first line you will be given the X coordinate.
⦁	At the second line you will be given the Y coordinate.
⦁	At the third line an integer number V will be given, specifying the value of the first cell.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console. It should consist of 1 line:
⦁	Print the value C of the cell at position {X, Y} raised to the power of its index.

     * 
     * */

    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int initialValue = int.Parse(Console.ReadLine());

            int index =y * 3 + x +1 ;
            int trueValue = initialValue + index - 1;
            long powered = (long)Math.Pow(trueValue, index);   // Math.Pow return only double (int) cast to int. the number in trueValue on power number index; 
            Console.WriteLine(powered);





        }
    }
}
