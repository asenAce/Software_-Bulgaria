using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04.CopyBinaryFile
{
    class CopyBinaryFile
    {
        static void Main(string[] args)
        {
            FileStream copiedFile = new FileStream("../../toCopy.jpg",FileMode.Open);
            FileStream newFile = new FileStream("../../copiedImage.jpg",FileMode.Create);

            using (copiedFile)
            {
                using (newFile)
                {
                    
                    byte[] buffer = new byte[4040];

                    while (true)
                    {
                        int readBytes = copiedFile.Read(buffer,0,buffer.Length);

                        if (readBytes == 0)
                        {
                            break;
                        }

                        newFile.Write(buffer,0,readBytes);
                    }
                }
            }

        }




    }
}
