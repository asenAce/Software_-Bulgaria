using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TaskSix.cs
{
    class ExtractHyperLink
    {
        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder();
            string input;

            while (true)
            {
                input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                sb.Append(input);
            }

            string pattern = @"<a\s+(?:[^>]*?\s*href\s*=(\s*)?)[""'\s]?([^\s"">(']+([^""]*\))?)";

            Regex rgx = new Regex(pattern);
            Match m = rgx.Match(sb.ToString());

            while (m.Groups[2].Success)
            {
                Console.WriteLine(m.Groups[2]);
                m = m.NextMatch();
            }
        }
    }
}
