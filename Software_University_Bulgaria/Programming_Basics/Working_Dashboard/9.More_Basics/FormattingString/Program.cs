using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingString
{
    class Program
    {
        static void Main()
        {
            //double pi = 1.234;
            //Console.WriteLine("{0:0.000000}", pi);

            int a = 2, b = 3;
            Console.Write("{0} + {1} =", a, b);
            Console.WriteLine("{0}" , a + b );
            //2+3=5

            Console.WriteLine("{0} *{1} = {2}" ,a,b,a*b);
            //2*3=6

            float pi = 3.144556676f;
            Console.WriteLine("{0:F2}", pi);    //3,14 or 3.14
            Console.WriteLine("Bye - Bye!");
        }
    }
}
