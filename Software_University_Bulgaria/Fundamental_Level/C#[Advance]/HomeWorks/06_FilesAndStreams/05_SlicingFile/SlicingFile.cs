using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _05.SlicingFile
{
    class SlicingFile
    {
        const string sourceFile = "../../file.txt";
        const string destination = "../../";

        static void Main(string[] args)
        {
            Console.WriteLine("Enter in how many parts do you want the file to be sliced:");
            int parts = int.Parse(Console.ReadLine());
            SplitFile(parts);
            Assemble(parts);

        }

        private static void Assemble(int parts)
        {
            byte[] buffer = new byte[4422];

            for (int i = 1; i <= parts; i++)
            {
                string source = String.Format("../../{0}.txt",i);

                FileStream partOfFile = new FileStream(source,FileMode.Open);
                FileStream assembledFile = new FileStream("../../assembled.txt", FileMode.Append);

                using (partOfFile)
                {
                    using (assembledFile)
                    {
                        while (true)
                        {
                            int bytesRead = partOfFile.Read(buffer,0,buffer.Length);

                            if (bytesRead == 0)
                            {
                                break;
                            }

                            assembledFile.Write(buffer,0,bytesRead);
                        }
                    }
                }
            }
        }

        private static void SplitFile(int parts)
        {
            byte[] buffer = new byte[4050];

            using (Stream input = File.OpenRead(sourceFile))
            {
                int index = 1;

                while (input.Position < input.Length)
                {
                    using (Stream output = File.Create(destination + "\\" + index + ".txt"))
                    {
                        int chunkBytesRead = 0;

                        while (chunkBytesRead < input.Length / parts)
                        {
                            int bytesRead = input.Read(buffer,0,buffer.Length);

                            if (bytesRead == 0)
                            {
                                break;
                            }

                            chunkBytesRead += bytesRead;
                            output.Write(buffer, 0, bytesRead);
                        }
                    }

                    index++;
                }
            }
        }




    }
}
