using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceSlides
{
    


    class Program
    {
        static void PrintHyphens(int count)
        {
            Console.WriteLine(new string('-', count));
        }

        static void Main(string[] args)
        {
            for( int i =1; i <=10;i++)
            {
                PrintHyphens(i);
            }
        }
    }
}
