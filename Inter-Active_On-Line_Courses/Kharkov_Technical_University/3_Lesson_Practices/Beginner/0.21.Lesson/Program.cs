
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._21.Lesson
{
    class Program
    {
        /**
         * Returns tru if values contains value,false otherwise.
         * 
         * */

        static bool Contains(decimal[] values,decimal value)
        {
            if (values == null)
            {
                throw new ArgumentException("values","array must not be null");
            }
            bool result = false;

            foreach (var item in values)
            {
                if (item == value)
                {
                    result = true;
                    break;
                }
            }

            return false;
        }


        static void Main(string[] args)
        {



        }
    }
}
