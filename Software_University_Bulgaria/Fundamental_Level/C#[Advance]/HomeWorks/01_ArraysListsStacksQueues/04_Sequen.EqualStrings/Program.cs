using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkFour.cs
{

    /*
     * Matrix Shuffling....
     * */
    class Program
    {
        static void Main(string[] args)
        {
            #region The Input
            Console.WriteLine("height =  ");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("width =   ");
            int width = int.Parse(Console.ReadLine());

            string[,] matrix = new string[height,width];

            #endregion The Input
            #region The Logic
             
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = Console.ReadLine();
                }
            }

            string input;
            string[] command;  // declare a array ID command TYPE string [] possition == command[1]  ; 

            while (!((input = Console.ReadLine()) == "END"))
            {
                command = input.Split(' ');
                if (command.Length == 5 && command[0] == "swap")
                {
                    int rowOne = int.Parse(command[1]);
                    int colOne = int.Parse(command[2]);
                    int rowTwo = int.Parse(command[3]);
                    int colTwo = int.Parse(command[4]);
                    string temp;

                    if ((rowOne >= 0 && rowOne < height) && (rowTwo >= 0 && rowTwo< height) && (colOne >=0 && colOne< width) &&
                        (colTwo >=0 && colTwo < width))
                    {
                        temp= matrix[rowOne,colOne];
                        matrix[rowOne, colOne] = matrix[rowTwo, colTwo];
                        matrix[rowTwo, colTwo] = temp;

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.WriteLine("{0,2}",matrix[row,col]);
                            }

                            Console.WriteLine();
                        }
                    }

                    else
                    {
                        Console.WriteLine("Invalid input..");
                    }
                }

                else
                {
                    Console.WriteLine("Invalid input...");
                }
            }

            #endregion The Logic
            #region The Output
            #endregion The Output


        }
    }
}
