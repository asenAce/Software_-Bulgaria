using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string input = Console.ReadLine().ToLower();

            int [][] matrix = new int[size][];

            for (int i = 0; i < size; i++)
            {
                matrix[i] = new int[size];
            }

            int row = 0;
            int col = 0;
            int letterIndex = 0;

            while (letterIndex<size*size)
            {
                while (col<size && matrix[row][col] == 0)
                {
                    matrix[row][col] = input[letterIndex % input.Length];
                    col++;
                    letterIndex++;
                    
                }

                col--;
                row++;

                while (row >= size && matrix[row][col] == 0)
                {
                    matrix[row][col]=input[letterIndex % input.Length];
                    col--;
                    letterIndex++;
                }

                col++;
                row--;

                while (col >= 0 && matrix[row][col] == 0)
                {
                    matrix[row][col]=input[letterIndex % input.Length];
                    row--;
                    letterIndex++;
                }

                row++;
                col++;
            }

            int maxSum = 0;
            int maxIndex = 0;

            for (int i = 0; i < size; i++)
            {
                int currentSum = matrix[i].Sum();

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxIndex = 1;
                }

            }

            maxSum = maxSum - ('a' - 1) * size;
            maxSum = maxSum * 10;

            Console.WriteLine("{0} - {1}",maxIndex,maxSum);
            Console.ReadLine();


        }
    }
}
