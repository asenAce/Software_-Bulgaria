using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016.LessonRectangleTwoDimentionaArray
{
   public  class RentFinder
    {
        //016.Lesson Rectangle TwoDimentionaArray.
        static void Main(string[] args)
        {
            int[,] rents = { {400,450,510},{500,560,630},{233,345,345},{1000,1250,1600}};

            int floor;
            int bedrooms;
            string inputString;

            Console.WriteLine("Please enter the floor on which you want to live.");
            inputString = Console.ReadLine();
            floor = Convert.ToInt32(inputString);

            Console.WriteLine("the numbers of bedrooms ");
            inputString = Console.ReadLine();
            bedrooms = Convert.ToInt32(inputString);

            Console.WriteLine("The rent is  {0} ",rents[floor,bedrooms]);
        }
    }
}
