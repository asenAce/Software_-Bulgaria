using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Headphones
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{0}", new string('_',(n-1)/2),new string('*',n+2));

            for (int i = 0; i < n-1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('_',(n-1)/2),new string('_',n));
            }

            for (int i = 0, count = 0; i < n; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}",
                    new string('_',((n-1 )/2)-count), // it is a - 
                    new string('*',1+2*count),
                    new string('_',n-2*count));

                if (i < n/2)
                {
                    count++;
                }
                else
                {
                    count--;
                }
                
            }
        }
    }
}
