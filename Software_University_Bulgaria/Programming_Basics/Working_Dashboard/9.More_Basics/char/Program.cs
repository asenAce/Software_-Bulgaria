using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @char
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = Console.Read();
            char ch = (char)i;  //Cast the int to char
            //Get the code of the entered symbol
            Console.WriteLine("The code of '{0}' is {1}." ,ch,i);
            Console.ReadLine();
        }
       
    }
}
