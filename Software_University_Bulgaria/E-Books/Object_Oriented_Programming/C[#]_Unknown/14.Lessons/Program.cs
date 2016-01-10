using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014.Lesson
{
    // sort()
    public class SortArray
    {
        static void Main(string[] args)
        {
            string[] names = { "Olive","Patty","Richard","Ned","Mindy"};
            int x;
            Array.Sort(names);

            for (  x = 0; x < names.Length; x++)
            {
                Console.WriteLine(names[x]);
            }
        }
    }

    
}
