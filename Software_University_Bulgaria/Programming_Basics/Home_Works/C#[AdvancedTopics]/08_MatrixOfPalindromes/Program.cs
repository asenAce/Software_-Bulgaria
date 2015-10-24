using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MatrixOfPalindromesTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Take the values from the user and put them into variables row,col with type int
            Console.WriteLine("Please enter the numbers of rows: ");
            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the number of colums:  ");
            int height = int.Parse(Console.ReadLine());
            //Create the matrix[,] one dimention [] parameters width,height
            string[,] matrix=new string[width,height];
            //Put value into the matrix nested for's
            for (int row = 0; row < width;row++ )
            {
                for (int col = 0; col < height;col++ )
                {
                    // = assign operator give values to the matrix = char ()()paramethers + concatination
                    matrix[row, col] = "" + (char)('a' + row) + (char)('a' + col + row) + (char)('a' + row);

                }


            }
            //Print the matrix to the console using again nested for's
            for(int row = 0;row<width;row++)
            {

                for (int col = 0; col < height;col++ )
                {

                    Console.Write(matrix[row,col] +" ");

                }
                Console.WriteLine();
                Console.ReadLine();

            }

        }
    }
}
