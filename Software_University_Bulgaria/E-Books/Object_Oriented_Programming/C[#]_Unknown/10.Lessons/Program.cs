using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010.Lesson
{
    // Chapter VI p.233

    class Program
    {
        static void Main(string[] args)
        {
            foreach (string day in Enum.GetNames(typeof(Day)))
            {
                Console.WriteLine(day);
            }

        }
    }

    public class DemoForEachWithEnum
    {
        enum Day
        {
            SUNDAY,MONDAY,TUESDAY,WEDNESDAY,THURSDAY,FRIDAY,SATURDAY
        }
        

    }

}
