using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._01.SortWords
{
    class Program
    {
        static void Main(string[] args)
        {
            //The Input
            List<string> list = new List<string>();
            string input = Console.ReadLine();

            //The Logic
            list = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            list.Sort();
            //List.ForEach(el => Console.Write(el + " "));
         
            //The OutPut
            Console.WriteLine();
        }
    }
}
