using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and initialize a matrix of size 2x 4
            int[,] matrix =
            {
                {1,2,3,4},  //row 0 values
                {1,2,3,4},  //row 1 values
            };

            for (int row = 0; row < matrix.GetLength(0);row++ )
            {
                for (int col = 0; col < matrix.GetLength(1);col++ )
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
                Console.ReadLine();
            }



        }
    }
}
