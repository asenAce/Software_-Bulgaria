using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summertime
{
    class Summertime
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            
            string top = new string('*', size + 1);
            string emptyTop = new string(' ', (size - 1) / 2);
            Console.WriteLine("{0}{1}{0}", emptyTop, top);

            for (int i = 0; i < size / 2 + 1; i++)
            {
                string emptyInside = new string(' ', size - 1);
                Console.WriteLine("{0}*{1}*{0}", emptyTop, emptyInside);
            }

            for (int i = 0; i < size - (2 + size / 2); i++)
            {
                string emptyOutside = new string(' ', size / 2 - 1 - i);
                string emptyInside = new string(' ', size + 1 + 2 * i);
                Console.WriteLine("{0}*{1}*{0}", emptyOutside, emptyInside);
            }

            for (int i = 0; i < size; i++)
            {
                string insideBottle = new string('.', size * 2 - 2);
                Console.WriteLine("*{0}*", insideBottle);
            }

            for (int i = 0; i < size; i++)
            {
                string insideBeer = new string('@', size * 2 - 2);
                Console.WriteLine("*{0}*", insideBeer);
            }

            string bottom = new string('*', size * 2);
            Console.WriteLine(bottom);
        }
    }
}
