using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOne.cs
{
    class Program
    {
        // Fill the Matrix

        static void Main(string[] args)
        {
            Console.WriteLine("State the nOne= ");
            int nOne = int.Parse(Console.ReadLine());

            Console.WriteLine("State the nTwo=");
            int nTwo = int.Parse(Console.ReadLine());

            int[,] matrix = new int[nOne, nTwo];
            int number = 0;

            //One set
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    number++;
                    matrix[row, col] = number;
                }
            }

            //Second set

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.WriteLine("{0,3}",matrix[row,col]);
                }

                Console.WriteLine();
            }

            // Print 

            Console.WriteLine("--------------------------");
            number = 0;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (col %2 == 0)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        number++;
                        matrix[row, col] = number;
                    }

                }
                else
                {
                    for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                    {
                        number++;
                        matrix[row, col] = number;
                    }
                }
            }


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.WriteLine("{0,3}",matrix[row,col]);
                }

                Console.WriteLine();
                
            }
        }
    }
}
