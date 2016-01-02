using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Methods
{
    class Program
    {
        static void Main(string[] args)
        {




        }


        public void WriteAsBytes(int value)
        {
            byte[] bytes = BitConverter.GetBytes(value);

            foreach ( byte b in bytes)
            {
                Console.WriteLine("0x{0:X2}",b);
            }

        }
    }
}
