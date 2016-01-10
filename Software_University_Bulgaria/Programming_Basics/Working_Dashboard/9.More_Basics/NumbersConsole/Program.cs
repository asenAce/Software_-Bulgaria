using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} +  {1} = {2}", a, b, a + b);
            Console.WriteLine("{0} *  {1} = {2}", a, b, a * b);

            float f = float.Parse(Console.ReadLine());
            Console.WriteLine("{0} * {1} / {2} = {3}", a, b, f, a * b / f);
            Console.Read(); 
        }
    }
}
