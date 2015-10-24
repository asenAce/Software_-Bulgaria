using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task08._01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n =  ");
            int n = int.Parse(Console.ReadLine());


            if ( n > 1 && n < 20)
            {
                for (int i = 1; i <= n;i++ )
                {
                    for (int j = i; j <= n+i;j++ )
                    {
                        Console.WriteLine( j + "  ");
                    }
                    Console.WriteLine();
                }

            }

            else
            {
                Console.WriteLine("invalide data! ");
            }
            Console.ReadLine();

        }
    }
}
