using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advanceC_exercise
{
    class TheMatrix
    {
        static void Main(string[] args)
        {

            Console.Write("Please state the numbers of rows and colums:  ");
            Console.WriteLine("rows: ");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("colums: ");
            int height = int.Parse(Console.ReadLine());

            string [,] matrix = new string [width,height];

            for(int row = 0;row<width;row++)
            {
                for (int col=0;col<height;col++ )
                {
                    matrix[row, col] = "  " + (char)('a' + row) + (char)('a' + row + col) + (char)('a' + row + col) + (char)('a' + row + col
                        )+(char)('a'+row);
                }
            }

            for(int row=0;row<width;row++)
            {
                for (int col = 0; col < height;col++ )
                {
                    Console.Write(matrix[row,col]+"  ");
                }
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
