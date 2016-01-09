using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingNumbersStr
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("a =  ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}+{1}={2}",a,b,a+b);
            Console.WriteLine("{0}+{1}={2}", a, b, a * b);
            Console.Write("f = ");
            double f = double.Parse(Console.ReadLine());
            Console.WriteLine("{0}*{1}/{2}={3}",a,b,f, a * b/f);
            Console.Read();
        }
    }
}
