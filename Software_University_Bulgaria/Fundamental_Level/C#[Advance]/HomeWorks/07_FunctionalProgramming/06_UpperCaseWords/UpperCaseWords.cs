using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Text.RegularExpressions;

namespace UpperCaseWords
{
    class UpperCaseWords
    {
        static void Main(string[] args)
        {
            // patterns and replaces
            List<string> patterns = new List<string>();
            List<string> replacers = new List<string>();

            while (true)
            {
                // input

                string line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }


                MatchUpperCaseWords(line,replacers,patterns);

                // replace uppercaseWords
                line = UpperCaseWordsReplacer(patterns,line,replacers);

                // print
                Console.WriteLine(SecurityElement.Escape(line));
            }

        }

        private static string UpperCaseWordsReplacer(List<string> patterns, string line, List<string> replacers)
        {
            for (int i = 0; i < patterns.Count; i++)
            {
                line = Regex.Replace(line, patterns[i], word => replacers[i]);
            }

            return line;
        }

        private static void MatchUpperCaseWords(string line, List<string> replacers, List<string> patterns)
        {
            string pattern = @"(?<![a-zA-Z])([A-Z]+)(?![A-Za-z])";
            Regex rgx = new Regex(pattern);
            MatchCollection matches = rgx.Matches(line);

            for (int i = 0; i < matches.Count; i++)
            {
                string word = matches[i].Groups[1].Value;
                string replacer = word;

                if (IsPalyndrome(word))
                {
                    replacer = DoubleLettersReplacer(replacer);
                }

                else
                {
                    replacer = ReverserReplacer(replacer, word);
                }

                replacers.Add(replacer);
                patterns.Add("(?<![a-zA-Z])("+ word + ")(?![A-Za-z])");
            }
        }

        private static string ReverserReplacer(string replacer, string word)
        {
            replacer = string.Join("",word.Reverse());
            return replacer;
        }

        private static string DoubleLettersReplacer(string replacer)
        {
            string patternLetter = @"[A-Z]";

            replacer = Regex.Replace(replacer,patternLetter, x=> String.Format("{0}{0}",x));
            return replacer;
        }


        private static bool IsPalyndrome(string word)
        {
            if (word.Length == 1)
            {
                return true;

            }

            int len = word.Length;

            for (int i = 0; i < len / 2; i++)
            {
                if (word[i] != word[len-i-1])
                {
                    return false;
                }
            }

            return true;
        }


    }
}
