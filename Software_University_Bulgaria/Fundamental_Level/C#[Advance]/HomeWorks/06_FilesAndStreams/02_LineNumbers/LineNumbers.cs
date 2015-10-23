using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02.LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../Text.txt");
            StreamWriter writer = new  StreamWriter("../../Text.txt"); 

            using(reader)
            {
                using(writer)
                {
                    string line = reader.ReadLine();
                    int lineNumber = 1;

                    while (line != null)
                    {
                        writer.WriteLine("{0,5}.{1}", lineNumber, line);
                        line = reader.ReadLine();
                        lineNumber++;
                    }
                }

            }

        }





    }
}
