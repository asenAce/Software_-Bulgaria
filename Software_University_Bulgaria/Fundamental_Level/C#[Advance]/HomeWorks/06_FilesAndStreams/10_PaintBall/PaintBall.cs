using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PaintBall
{
    class PaintBall
    {
        static void Main(string[] args)
        {

            int[,] matrix = new int[10,10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matrix[i, j] = 1;
                } 
            }

            Console.WriteLine("Shot");
            string shot = Console.ReadLine();
            int numberOfShots = 1; // keep track

            while (shot != "End")
            {
                string[] shotString = shot.Split(' ');
                int[] shotImpact = new int[3];

                for (int i = 0; i < 3; i++)
                {
                    shotImpact[i] = int.Parse(shotString[i]); // converting the number to int.

                }

                int lowRow = GettingTheLowRow(shotImpact[0],shotImpact[2]); // getting low row and check if it gets outside the a
                int highRow = GettingTheHighRow(shotImpact[0], shotImpact[2]); // getting the high row and check if it gets outside
                int lowColon = GettingTheLowColon(shotImpact[1], shotImpact[2]);
                int highColon = GettingTheHighColon(shotImpact[1],shotImpact[2]);

                if (numberOfShots % 2 == 1) // painting black zero odds
                {
                    for (int i = lowRow; i <= highRow; i++)
                    {
                        for (int j = lowColon; j <= highColon; j++)
                        {
                            matrix[i, j] = 0;
                        }
                    }
                }

                else if(numberOfShots % 2 == 0 ) // painting white ones even
                {
                    for (int i = lowRow; i <= highRow; i++)
                    {
                        for (int j = lowColon; j <= highColon; j++)
                        {
                            matrix[i, j] = 1;
                        }
                    }
                }

                numberOfShots++; // keeping track of shots
                shot = Console.ReadLine(); // next shot.


            }

            long result = 0;
            string rowBinary = "";

            for (int row = 0; row < 10; row++)
            {
                for (int col = 9; col >= 0; col--)
                {
                    rowBinary += matrix[row,col];
                }

                result += Convert.ToInt64(rowBinary,2);
                rowBinary = "";
            }

            Console.WriteLine(result);


        }

        private static int GettingTheHighColon(int col, int radius)
        {
            if (col + radius > 9)
            {
                col = 9;
            }

            else
            {
                col += radius;
            }

            return col;
        }

        private static int GettingTheLowColon(int col, int radius)
        {
            if (col - radius < 0)
            {
                col = 0;
            }

            else
            {
                col -= radius;
            }

            return col;
        }

        private static int GettingTheHighRow(int row, int radius)
        {
            if (row + radius > 9)
            {
                row = 9; 
            }

            else
            {
                row += radius;
            }

            return row;
        }

        private static int GettingTheLowRow(int row, int radius)
        {
            if (row - radius < 0)
            {
                row = 0;
            }

            else
            {
                row -= radius;
            }

            return row;
        }
    }
}
