using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTwo.cs
{
    class StringLength
    {
        /*
         * Task Two String Lenght
         * */

        static void Main(string[] args)
        {
            Console.WriteLine("Give me your love , i mean your string....");
            string love = Console.ReadLine();

            StringBuilder outLove = new  StringBuilder(love);

            int length = outLove.Length;

            if (length >= 20)
            {
                outLove.Remove(20,outLove.Length - 20);
            }

            else
            {
                outLove.Append('*',20 - outLove.Length);
            }

            Console.WriteLine(outLove.ToString());

        }
    }
}
