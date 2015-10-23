using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.HWDisk
{
    class Program : Disk
    {
        static void Main(string[] args) 
        {
            /*
             * In geometry , a disk is the region in a plane bounded by a circle it also includes the circle itself...
             * */

            #region Input
            Console.WriteLine("The size of the field");
            int sizeOfField = int.Parse(Console.ReadLine());

            for (int y = 0; y <= sizeOfField; y++)
            {
                for (int x = 1; x <= sizeOfField; x++)
                {
                    if (IsPointInsideTheDisk(sizeOfField,radius,x,y))
                    {
                        Console.WriteLine('*');
                    }

                    else
                    {
                        Console.WriteLine('.');
                    }
                }

                Console.WriteLine();
            }

            #endregion Input
        }
    }
}
