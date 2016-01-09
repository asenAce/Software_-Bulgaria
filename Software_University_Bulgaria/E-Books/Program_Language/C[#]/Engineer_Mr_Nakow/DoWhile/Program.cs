using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            decimal factorial = 1;

            do
            {
                factorial *= n;
                n--;
            } while (n > 0);
            Console.WriteLine("n! = " + factorial);
            Console.ReadLine();
        }
    }
}
