using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the numbers of rows and colums ");
            Console.WriteLine("rows:  ");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("colums: ");
            int height = int.Parse(Console.ReadLine());

            string[,] matrix = new string[width, height];

            for( int row = 0 ; row<width;row++)
            {
                for (int col = 0; col < height;col++ )

                {
                    matrix[row,col]="  "+(char)('a'+row)+(char)('a'+col+row)+(char)('a'+row);
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
