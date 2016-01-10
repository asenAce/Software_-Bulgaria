using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Star
{
    /**
     * You will be given an integer N. Your task is to draw a star on the console. The width of the star is (2*N+1). The height of the star is (N*2 - (N/2-1)). The top and the middle part height is exactly (N/2). The height of the legs is (N/2+1). Check the examples below to understand your task better.
Input
The input data is read from the console. The number N stays alone at the first line. The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data must be printed on the console.
You must print at the console a star of size N following the formulas above and the examples below.
Constraints
N will be a number between 6 and 36 and will be an even number.
Allowed working time: 0.2 seconds. Allowed memory: 16 MB.

     * */

    class Star
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            // Those are the formulas
            int width = 2 * n + 1;
            int height = (n * 2 - (n / 2 - 1));
            // diferent moduls
            int topMiddleHeight = n / 2;
            int legsHeight = n / 2 + 1;

            string outerDots = new string('.',n);
            string middleDots = "";
            Console.WriteLine("{0}*{0}",outerDots,outerDots);  // This is a static and the beggining of the star

            //
            for (int i = 0; i < topMiddleHeight -1; i++)
            {
                outerDots = new string('.',n-i-1);
                middleDots = new string('.',i*2+1);
                Console.WriteLine("{0}*{1}*{0}",outerDots,middleDots,outerDots); //Drawing with placeholder
            }
            // This is line 4 of the image , the same as the last line that is why we copy the code and passed it...s
            string asterisks = new string('*',n/2+1);
            middleDots = new string('.', n - 1);
            Console.WriteLine("{0}{1}{0}",asterisks,middleDots,asterisks);

            for (int i = 0; i < topMiddleHeight - 1; i++)  //Upper Middle section of the star
            {
                int outerDotsLenght = i + 1;
                outerDots = new string('.',outerDotsLenght);
                middleDots = new string('.',width-2*outerDotsLenght-2);
                Console.WriteLine("{0}*{1}*{0}",outerDots,middleDots);
            }
            outerDots = new string('.', n / 2);
            string legsDots = new string('.',n/2-1);
            Console.WriteLine("{0}*{1}*{1}*{0}",outerDots,legsDots,legsDots,outerDots);

            //The bottom 
            for (int i = 0; i < legsHeight; i++)
            {
                outerDots = new string('.',n/2-i-1);
                middleDots = new string('.',i*2+1);
                Console.WriteLine("{0}*{1}*{2}*{1}*{0}",outerDots,legsDots,middleDots);
            }


            string asterisksTwo = new string('*', n / 2 + 1);
            middleDots = new string('.', n - 1);
            Console.WriteLine("{0}{1}{0}", asterisksTwo, middleDots);
        }
    }
}
