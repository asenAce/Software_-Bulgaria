using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TheCar
{
    /**
     * – Car
You will be given an integer N. The width of the car is (3*N). The height of the car is (3*N/2-1).  The roof height and the body height is exactly (N/2).  The car’s wheels height are (N/2-1). Check the examples below to understand your task better.
Input
     * 
Input data is read from the console.
The number N stays alone at the first line.
The input data will always be valid and in the format described. There is no need to check it explicitly.
     * 
Output
The output data must be printed on the console.
You must print at the console a car of size N following the formulas above and the examples below.
Constraints
N will be a number between 6 and 36 and will be an even number.
Time limit: 0.25 seconds.
Allowed memory: 16 MB.

     * 
     * 
     * */


    class TheCar
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int length = n + (n / 2 - 1);   // This is the logic the formula that we calculate the last few lines for the picture.
            // ov vertical.
            string theLine=" ";        //Or string =""; i declare empty stirng""; which i am gonna use latter 
            int outerDots = n;  //I creating counters 
            int innerDots = n;


            for (int row = 0; row <= length; row++)
            {
                if (row == 1)
                {
                    theLine = new String('.',outerDots) + new String('*',n) + new String('.',outerDots); // Using the declared empty line;, 3 moduls!
                    //left , middle , right
                    outerDots--;
                }
                else if (row >1 && row<= n/2)
                {
                    theLine = new String('.',outerDots) + "*" + new String('.',innerDots) + "*" + new String('.',outerDots) ;
                    outerDots--;
                    innerDots += 2;
                }
                else if (row == n / 2 + 1)
                {
                    theLine = new String('*',outerDots + 1)  + new String('.',innerDots) + new String('*',outerDots+1);
                    innerDots = innerDots + n;
                }

                else if (row > n / 2 + 1 && row <= n-1)
                {
                    theLine = "*" + new String('.', innerDots) + "*";
                }
                else if (row == n)
                {
                    theLine = new String('*', innerDots + 2);
                }
                else if (row > n && row <= length - 1)
                {
                    theLine = new String('.', outerDots) + "*" + new String('.', outerDots - 1) + "*" + new String('.',n-2) + 
                        "*" + new String('.', outerDots -1) + "*" + new String('.', outerDots); // before the last line drawing
                    // the wheels of the car!  
                }

                else
                {
                    theLine = new String('.', outerDots) +  new String('*', outerDots + 1)+ new String('.', n - 2) + 
                        new String('*', outerDots + 1)+ new String('.', outerDots);
                    break;
                }

                Console.WriteLine(theLine);



            }




        }
    }
}
