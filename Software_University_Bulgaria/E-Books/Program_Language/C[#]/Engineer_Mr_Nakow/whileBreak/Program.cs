using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //"decimal" is the biggest type that can hold integer values
            decimal factorial = 1;
            //Perform an "infinitive loop"
            while(true)
            {
                if(n <= 1)
                {
                    break;
                }
                factorial *= n;
                n--;
            }
            Console.WriteLine("n! =  " + factorial);
            Console.ReadLine();
        }
    }
}
