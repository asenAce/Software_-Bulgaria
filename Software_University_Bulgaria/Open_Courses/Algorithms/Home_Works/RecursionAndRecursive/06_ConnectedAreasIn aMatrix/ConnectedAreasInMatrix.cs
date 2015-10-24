using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSix.cs
{
    

    class ConnectedAreasInMatrix
    {
        private static SortedSet<Area> matches = new SortedSet<Area>();
        private static int areaSize = 0;
        private static char[,] maze =
        {
            {'*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' '},
            {'*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' '},
            {'*', ' ', ' ', '*', '*', '*', '*', '*', ' ', ' '},
            {'*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' '},
            {'*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' '}
        };

        static void Main()
        {
            Discover();
            PrintAreas();
        }

        static void Discover()
        {
            for (int row = 0; row < maze.GetLength(0); row++)
            {
                for (int col = 0; col < maze.GetLength(1); col++)
                {
                    if (maze[row, col] == ' ')
                    {
                        Mark(row, col);
                        matches.Add(new Area(areaSize, row, col));
                        areaSize = 0;
                    }
                }
            }
        }

        static void Mark(int row, int col)
        {
            if (row < 0 || col < 0 || row >= maze.GetLength(0) || col >= maze.GetLength(1))
            {
                return;
            }

            if (maze[row, col] == '%' || maze[row, col] == '*')
            {
                return;
            }

            areaSize++;
            maze[row, col] = '%';

            Mark(row, col + 1);
            Mark(row + 1, col);
            Mark(row, col - 1);
            Mark(row - 1, col);
        }

        static void PrintAreas()
        {
            if (matches.Count <= 0)
            {
                Console.WriteLine("No area's found!");
            }
            else
            {
                int areaNum = 1;
                foreach (var area in matches)
                {
                    Console.WriteLine(
                        "Area #{0} at {1}",
                        areaNum,
                        area
                        );

                    areaNum++;
                }
            }
        }
    }
}
