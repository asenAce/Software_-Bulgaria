using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 5;
            b = 10;

            Console.WriteLine(" a = {0}" ,a);
            Console.WriteLine(" b = {0}", b);

            int holder = a;
            a = b;
            b = holder;
            Console.WriteLine("After the Exchange \na = {0}\nb = {1} ",a,b);
            Console.Read();
        }
        
    }
    
}
