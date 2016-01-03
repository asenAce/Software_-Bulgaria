
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ListDemo
{
    class Program
    {
        // 06. Lesson ListDemo 
        static void Main(string[] args)
        {

            List<int> list = new List<int>()
            {
                1,2,3,45,6,13
            };

          var ordered =   list.OrderBy((v) => v % 3).ThenByDescending((v) => v);
            Console.WriteLine(String.Join(",",ordered));
        }
    }
}
