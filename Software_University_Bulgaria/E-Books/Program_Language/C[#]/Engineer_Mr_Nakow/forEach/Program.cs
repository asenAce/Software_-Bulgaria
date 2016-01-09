using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] capitals = 
            { "Sofia","NY","London","Paris"};

            foreach( string captal in capitals)
            {
                Console.WriteLine(capitals);
            }

            Console.ReadLine();

        }
    }
}
