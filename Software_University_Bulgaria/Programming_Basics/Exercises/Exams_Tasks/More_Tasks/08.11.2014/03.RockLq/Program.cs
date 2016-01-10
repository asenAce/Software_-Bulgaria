
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RockLq
{
    /**
     * You will be given an integer N. The width of the rocklq is (3*N). The height of the rocklq is (2*N). Check the examples below to understand your task better.

     * Input
     * 
Input data is read from the console.
The number N stays alone at the first line.
The input data will always be valid and in the format described. There is no need to check it explicitly.

     * Output
     * 
The output data must be printed on the console.
You must print at the console a picture of size N following the formulas above and the examples below.
Constraints
N will be a number between 5 and 31 and will be an odd number.
Time limit: 0.25 seconds. Allowed memory: 16 MB.

     * 
     * */
    class Program
    {
        static void Main(string[] args)
        {
            // Input

            int size = int.Parse(Console.ReadLine());

            // Logic
            int outerDots = size;
            int innerDots = size - 2;

            // Output the first line. Draw the first line of the picture.
            Console.WriteLine("{0}*{1}*{0}", new String('.', outerDots), new String('*', innerDots));    // , new String('*',innerDots)
            
           

            for (int i = 0; i < size / 2 ; i++)
            {
                // the value of those two variables now changed !
                outerDots -= 2;
                innerDots += 4;
                Console.WriteLine("{0}*{1}*{0}", new String('.', outerDots), new String('.', innerDots)); // New string place holder.
                
            }

            // Draw the middle module on the console.
            Console.WriteLine("*{0}*{1}*{0}*",new String('.',size -2 ), new String('.',size));
            // the value of those two variables now changed !, so the programe can use it in the for cycle.
            innerDots = 1;
            outerDots = size - 4;

            for (int i = 0; i < size / 2 - 1; i++)
            {
                Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*",new string('.',outerDots),new string('.',innerDots),new string('.',size));
                innerDots += 2;
                outerDots -= 2;
            }

            outerDots = size - 1;
            innerDots = size;

            // Down module.
            for (int i = 0; i < size -1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new String('.', outerDots), new String('.', innerDots));
                // the value of those two variables now changed ! , to form the picture
                outerDots--;
                innerDots += 2;
            }

            

            // Drawing the last module of the picture just ***************
            Console.WriteLine(new String('*',3 * size));

            // Output






        }
    }
}
