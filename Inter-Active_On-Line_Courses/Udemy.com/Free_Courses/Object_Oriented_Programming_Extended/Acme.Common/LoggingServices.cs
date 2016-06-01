using Acme.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Common
{
    public class LoggingServices
    {
        public static void WriteToFile(List<ILoggable> changeItems)
        {
            foreach (var item in changeItems)
            {
                // more code >>
               
                Console.WriteLine(item.Log());


            }
        }

    }
}
