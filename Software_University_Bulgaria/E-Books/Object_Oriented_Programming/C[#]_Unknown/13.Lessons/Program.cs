using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013.Lesson
{
    /**
     * page 248 chapter VI Binary Search
     * */
    class Program
    {
        static void Main(string[] args)
        {
            int[] idNumbers = { 122,222,342,123,455};
            int x;
            string entryString;
            int entryID;
            Console.WriteLine("Enter an Employee ID");
            entryString = Console.ReadLine();
            entryID = Convert.ToInt32(entryString);

            x = Array.BinarySearch(idNumbers,entryID);

            if (x < 0 )
            {
                Console.WriteLine("ID {0} not found",entryID);
            }
            else
            {
                Console.WriteLine("ID {0} found at position {1}",entryID,x);
            }

        }
    }
}
