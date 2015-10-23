using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TaskThree.cs
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input...");
            string input = Console.ReadLine();

            Regex rgx = new Regex(@"[\w._-]*@[\w._-]*\w");
            MatchCollection matches = rgx.Matches(input);

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }





    }
}
