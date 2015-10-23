using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkTwo.cs
{
    class Program
    {
        /*
         * Maximal Sum.
         * */

        static void Main(string[] args)
        {
            #region The Input

            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int height = input[0];
            int width = input[1];
            int[,] matrix = new int[height + 1,width +1];

            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;
            #endregion The Input
            #region The Logic
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1)-2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }
            #endregion The Logic

            #region OutPut

            Console.WriteLine("Sum = {0}",bestSum);
            Console.WriteLine("{0} {1} {2}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1]
                , matrix[bestRow, bestCol + 2]);
            Console.WriteLine("{0} {1} {2}",matrix[bestRow + 1, bestCol],matrix[bestRow + 1, bestCol + 1],
                matrix[bestRow + 1, bestCol+ 2]);
            Console.WriteLine("{0} {1} {2}", matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1],
                matrix[bestRow + 2, bestCol + 2]);

            #endregion OutPut

        }
    }
}
