using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.HWDisk
{
    class Disk
    {
        static bool isPointInsideTheDisk(int sizeOfField,int radius,int x,int y)
        {
            int centerX = sizeOfField / (2 + 1);
            int centerY = sizeOfField / (2 + 1);

            if ((x - centerX) * (x- centerX) + (y - centerY) * (y -centerY) <= radius * radius)
            {
                return true;
            }

            return false;
        }


    }
}
