using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n = ?");
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n;row++ )
            {
                for (int col = 1; col <= row; col++ )
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            

        }
    }
}
