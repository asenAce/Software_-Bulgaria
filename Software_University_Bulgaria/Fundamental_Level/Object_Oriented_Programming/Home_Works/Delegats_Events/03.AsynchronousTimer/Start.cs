using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AsynchronousTimer
{
    class Start
    {
        static void Main(string[] args)
        {

            

            var async = new AsyncTimer(Console.WriteLine,10,1000,"Hello");
            Console.WriteLine("Will print 10 times \"Hello\"with delay of 1000ms: ");
            async.Run();
            
        }
    }
}
