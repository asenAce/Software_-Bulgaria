using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Disk
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());
        int innerR = int.Parse(Console.ReadLine());
        int center = n / 2;

        for (int j = 0; j < n; j++)
        {
            for (int i = 0; i < n; i++)
            {
                int x = center - i;
                int y = center - j;
                double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                if (distance <= r)
                {
                    if (distance > innerR)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
}
