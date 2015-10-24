using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFive.cs
{
    using System;
    using System.Collections.Generic;

    class Paths
    {
        static char[,] maze =
        {
            {'S', ' ', ' ', ' ', ' ', ' '},
            {' ', '*', '*', ' ', '*', ' '},
            {' ', '*', '*', ' ', '*', ' '},
            {' ', '*', 'E', ' ', ' ', ' '},
            {' ', ' ', ' ', '*', ' ', ' '}
        };
        private static int solutionsFound = 0;
        static List<char> path = new List<char>();

        static void Main()
        {
            Move(0, 0, 'S');
            Console.WriteLine("Total paths found: {0}", solutionsFound);
        }

        static void Move(int row, int col, char dir)
        {
            if (row < 0 || col < 0 || row >= maze.GetLength(0) || col >= maze.GetLength(1))
            {
                return;
            }

            path.Add(dir);

            if (maze[row, col] == 'E')
            {
                Console.WriteLine(string.Join("", path));
                solutionsFound++;
            }

            if (maze[row, col] == ' ' || maze[row, col] == 'S')
            {
                maze[row, col] = 'X';

                Move(row, col + 1, 'R');
                Move(row + 1, col, 'D');
                Move(row, col - 1, 'L');
                Move(row - 1, col, 'U');

                maze[row, col] = ' ';
            }

            path.RemoveAt(path.Count - 1);
        }
    }
}
