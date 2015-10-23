using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TaskEight.cs
{
    class UseYourChainsBuddy
    {
        static void Main(string[] args)
        {
            string removeSpaceCharacters = @"(\+|%20)";
            string removeSpaces = @"(\s{2,})";
            string pattern2 = @"(?:[^\?])*?([a-zA-Z0-9\s\*-._]*)=([^\&]*)&?(?:\s)?";

            Regex rgx = new Regex(pattern2);


            string input = Console.ReadLine();
            while (input != "END")
            {
                string result = Regex.Replace(input, removeSpaceCharacters, " ");
                result = Regex.Replace(result, removeSpaces, " ");

                Match m = rgx.Match(result);

                Dictionary<string, List<string>> matches = new Dictionary<string, List<string>>();

                while (m.Success)
                {
                    string group1 = m.Groups[1].ToString().Trim();
                    string group2 = m.Groups[2].ToString().Trim();
                    if (matches.ContainsKey(group1))
                    {
                        matches[group1].Add(group2);
                    }
                    else
                    {
                        matches.Add(group1, new List<string> { group2 });
                    }
                    m = m.NextMatch();
                }

                foreach (var pair in matches)
                {
                    Console.Write("{0}=[{1}]", pair.Key, string.Join(", ", pair.Value));
                }
                Console.WriteLine();
                input = Console.ReadLine();
            }
        }

    }
}
