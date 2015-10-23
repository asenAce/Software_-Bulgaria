using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSix.cs
{
    class Program
    {
        /*
         * Collect the coins.
         * */

        static void Main(string[] args)
        {
            #region Input
            UTF8Encoding utf8 = new UTF8Encoding();
            string[] matrix = new string[4];

            int row = 0;
            row = 0;
            int col = 0;
            int coins = 0;
            int wallsHit = 0;
            bool positionChanged = true;
            #endregion Input

            #region Logic
            for (  row = 0; row < 4; row++)
            {
                matrix[row] = Console.ReadLine();
            }
            string command = Console.ReadLine();

            for (int i = 0; i < command.Length; i++)
            {
                if (matrix[row][col] == '$' && positionChanged)
                {
                    coins++;
                }

                if (command[i] == '>' && col + 1 <= matrix[row].Length)
                {
                    col++;
                    positionChanged = true;
                }

                else if (command[i] == '<' && col -1 >= 0)
                {
                    col--;
                    positionChanged = true;
                }

                else if (command[i] == '^' && row - 1 >= 0 && matrix[row - 1].Length>col)
                {
                    row--;
                    positionChanged = true;
                }

                else if (command[i]== 'V' && row + 1 < matrix.Length && matrix[row + 1].Length> col)
                {
                    row++;
                    positionChanged = true;
                }

                else
                {
                    wallsHit++;
                    positionChanged = false;
                }
            }

            #endregion Logic

            #region Output

            Console.WriteLine("Coins collected: {0}",coins);
            Console.WriteLine("Walls hit:  {0}",wallsHit);
            #endregion Output



        }
    }
}
