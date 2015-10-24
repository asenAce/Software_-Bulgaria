using System;

class SummertimeForProgrammers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string whiteSpaces = new string(' ', n/2);
        Console.WriteLine("{0}{1}{0}", whiteSpaces, new string('*', n + 1));
        for (int i = 0; i < n / 2 + 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", whiteSpaces, new string(' ', n - 1));
        }

        for (int i = 0; i < n / 2 - 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string(' ', n/2-i-1), new string(' ', n + 1 + 2 * i));
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("*{0}*", new string('.', 2 * n - 2));
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("*{0}*", new string('@', 2 * n - 2));
        }

        Console.WriteLine("{0}", new string('*', 2 * n));
    }
}

