using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ListSimpleExample
{
    class Program
    {
        // 06.ListSimpleExample 

        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();
            
            

            var list = new List<string>()
            {
                "C#",
                "Python",
                "Java",
            };

            list.Add("SQL");
            list.Add("JavaScript");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
