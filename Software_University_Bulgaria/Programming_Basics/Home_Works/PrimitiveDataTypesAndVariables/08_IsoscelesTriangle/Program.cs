using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoscelesTriangle
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode; // givin a order to the console!

            char copyRight = '\u00A9';      // The code in the http://unicode-table.com/en/00A9/
            char space = ' ';   //Give us a space!
            int  num = 4;  // How many rolls 

            for( int i =0 ; i < num; i++ )  
            {
                for (int j = num - i; j > 0; j-- )     //Nested if's
                {
                    Console.Write("{0}",space);
                }
                for (int j = 0; j <= i; j++ )
                {
                    Console.Write("{0:U}{1}", copyRight, space);
                }
                Console.WriteLine();
                
            }

            Console.Read();
            
        }
    }

}
