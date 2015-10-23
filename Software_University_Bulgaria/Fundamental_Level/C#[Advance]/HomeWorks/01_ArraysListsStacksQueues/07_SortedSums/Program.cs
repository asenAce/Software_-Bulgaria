using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSeven.cs
{
    class Program
    {
        /*
         * Count Symbols
         * */
        static void Main(string[] args)
        {
            Console.WriteLine("The symbols:  ");
            char[] symbols = Console.ReadLine().ToCharArray();

            Array.Sort(symbols);
            var groups = symbols.GroupBy(x => x);

            foreach (var group in groups)
            {
                Console.WriteLine("{0} : {1} time/s",group.Key,group.Count());
            }


        }
    }
}
