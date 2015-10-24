using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotesInStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string var1 = "The \" use \" of quotations ";
            string var2 = "causes difficulties.";

            Console.WriteLine( var1 + var2);
            Console.ReadLine();
        }
    }
}
