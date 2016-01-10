using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertStringToNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "123";
            int i = int.Parse(s);       // i = 123
            long l = long.Parse(s);     // l = 123L
            string invalid = "xxx1845";
            int value = int.Parse(invalid); // FormatException
            Console.Read();
        }
    }
}
