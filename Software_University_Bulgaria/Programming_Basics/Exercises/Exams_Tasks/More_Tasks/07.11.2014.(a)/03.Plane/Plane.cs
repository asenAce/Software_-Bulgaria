using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Plane
{

    /**
     * Plane
You will be given an integer N. The width of the rocklq is (3*N). The height of the plane is ((N * 3) – (N / 2)) and the width is (N * 3). Check the examples below to understand your task better.
Input
Input data is read from the console.
The number N stays alone at the first line.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data must be printed on the console.
You must print at the console a picture of size N following the formulas above and the examples below.
Constraints
N will be a number between 5 and 31 and will be an odd number.
Time limit: 0.25 seconds. Allowed memory: 16 MB.

     * 
     * 
     * */

    class Plane
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            int width = N * 3;
            int height = (N * 3) - (N / 2);

            int left = ((3 * N) - 1) / 2;
            int right = left;

            while (left > N - 2)
            {
                for (int col = 0; col < N * 3; col++)
                {
                    if (col == left || col == right)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
                left--;
                right++;

            }
            left--;
            right++;
            while (left >= 1)
            {
                for (int col = 0; col < N * 3; col++)
                {
                    if (col == left || col == right)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
                left -= 2;
                right += 2;

            }
            left = N - 1;
            right = width - N;
            int initialLeft = left;
            int initialRight = right;

            while (left >= 2)
            {
                for (int col = 0; col < N * 3; col++)
                {
                    if (col == left || col == right || col == 0 || col == width - 1 ||
                        col == initialLeft || col == initialRight)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
                left -= 2;
                right += 2;
            }

            left = initialLeft;
            right = initialRight;

            while (left >= 0)
            {
                for (int col = 0; col < N * 3; col++)
                {
                    if (col == left || col == right || left == 0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
                left--;
                right++;

            }
        }
    }
}
