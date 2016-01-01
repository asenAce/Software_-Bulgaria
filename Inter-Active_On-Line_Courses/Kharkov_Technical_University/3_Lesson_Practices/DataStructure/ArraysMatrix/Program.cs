using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NB_ArraysMatrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int width = 4;
            int height = 6;

            string[,] matrix = new string[height,width];

            for (  int row = 0 ; row < height; row ++)
            {
                for (int col = 0; col < width; col++ )
                {
                    matrix[row,col] = " " + (char)('a' + row) + (char)('a' + col);
                    Console.WriteLine(matrix);
                    Console.ReadLine();
                }
            }

            Console.WriteLine(matrix);
            Console.ReadLine();



        }
    }
}
