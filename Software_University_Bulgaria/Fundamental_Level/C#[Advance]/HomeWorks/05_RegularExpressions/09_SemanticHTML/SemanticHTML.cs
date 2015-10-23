
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TaskNine.cs
{
    class SemanticHTML
    {
        static string pattern = @"<\s*?(div)[\w\W]*?((id|class)\s*?=\s?""([\w\W]*?)"")";
        static string pattern2 = @"<\/div>(\s*?[<!--]*[\s]*?(\b[a-zA-Z]*\b)[\s\S]*?>)";
        private static string pattern3 = @"(?<=\s)\s+(?![^<>]*<)";


        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> lines = new List<string>();
            while (input != "END")
            {
                lines.Add(input);
                input = Console.ReadLine();
            }

            for (int i = 0; i < lines.Count; i++)
            {
                lines[i] = firstTest(lines[i]);
            }

            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }

        }

        public static string firstTest(string x)
        {

            StringBuilder input = new StringBuilder(x);
            Match m = Regex.Match(input.ToString(), pattern);
            if (m.Success)
            {
                string divName = m.Groups[4].ToString();
                input.Replace("div", divName);
                input.Replace(m.Groups[2].ToString(), "");
            }
            return secondTest(input.ToString());
        }

        public static string secondTest(string x)
        {
            StringBuilder input = new StringBuilder(x);
            Match m = Regex.Match(input.ToString(), pattern2);
            if (m.Success)
            {
                string divName = m.Groups[2].ToString();
                input.Replace("div", divName);
                input.Replace(m.Groups[1].ToString(), "");
            }
            return removeWhiteSpaces(input.ToString());
        }

        public static string removeWhiteSpaces(string x)
        {
            if (x.Contains('<'))
            {
                return Regex.Replace(x, pattern3, "");
            }
            return x;
        }




    }
}
