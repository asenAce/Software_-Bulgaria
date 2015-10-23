using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TaskTwo.cs
{
    class ReplaceATag
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input");
            string input = Console.ReadLine();

            string pattern = @"<a(.*?)>(.*)<\/a>";
            string replace = @"[URL$1]&2[/URL]";

            input = Regex.Replace(input, pattern, replace);
            Console.WriteLine(input);
        }

    }
}
