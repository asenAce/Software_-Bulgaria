using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesAndStreamsHW
{
    class OddLines
    {
        static void Main(string[] args)
        {

            StreamReader reader = new StreamReader("../../Text.txt");
             
            using(reader)
            {
                int numberOfLine = 1;
                string line = reader.ReadLine();

                while (line != null)
                {
                    if (numberOfLine %2 == 1)
                    {
                        Console.WriteLine(line);
                    }

                    numberOfLine++;
                    line = reader.ReadLine();

                }
            }
        }
    }
}
