using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Magic_Wand
{
    //draw star in the console!

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 3 * n + 2;

            Console.WriteLine(
                "{0}*{0}",new string('.',width/2));

            int iterations = n / 2 + 1;

            for (var i = 1; i < iterations; i++)
            {
                Console.WriteLine(
                    "{0}*{1}*{0}",
                    new string('.', (width/2)-i),
                    new string('.', (2*i)-1)
                    );
            }
            Console.WriteLine(
                "{0}{1}{0}",
                new string('*',n),
                new string('.',width - 2* n)
                );

            for (var i = 1; i <=n/2; i++)
            {
                Console.WriteLine(
                    "{0}*{1}*{0}",
                    new string('.',i),
                    new string('.',width - (2 * (i)+(2)))
                    );
            }
/**
            for (var i = 0; i <= n/2 - 1; i++)
            {
                Console.WriteLine(
               //     "{0}*{1}*{2}*{3}*{2}*{1}*{0}",
                    new string('.',0 ),
                    new string('.', n/2),
                    new string('.')
                    );
            }
 * */

        }
    }
}
