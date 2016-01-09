using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    class Program
    {

        //create list <>
        static void Main(string[] args)
        {
            var fruitList = new List<string>();

            fruitList.Add("Apple");
            fruitList.Add("Orange");
            fruitList.Add("Fig");

            foreach (var item in fruitList)
            {
                Console.WriteLine(item);
            }

            fruitList.Sort();

            foreach (var item in fruitList)
            {
                Console.WriteLine(item);
            }

            ReportOnFigs(fruitList);

            Console.ReadLine();
        }

        //I create d a method
        static void ReportOnFigs(List<string> items)
        {
            string figReport =
                items.Contains("Fig", StringComparer.OrdinalIgnoreCase) ?
                "Yes there are a figs" : "No there are not";
            Console.WriteLine(figReport);
         }
    }
}
