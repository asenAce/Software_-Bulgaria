using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int innerWidth = width - 2;

            string frame = new string('*', width);
            Console.WriteLine("{0}", frame);

            for (int row = 0; row < (width - 2) / 2; row++)
            {
                string line = new string('-', (innerWidth / 2) - row);
                string diamond = new string('@', 1 + (row * 2));

                Console.WriteLine("*{0}{1}{0}*", line, diamond);
            }

            for (int row = 0; row <= (width - 2) / 2; row++)
            {
                string line = new string('-', row);
                string diamond = new string('@', (innerWidth - (2 * row)));

                Console.WriteLine("*{0}{1}{0}*", line, diamond);
            }

            Console.WriteLine("{0}", frame);
        }
    }
}
