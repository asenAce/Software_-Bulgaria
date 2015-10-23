using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LittleJohn
{
    class LittleJohn
    {
        static void Main(string[] args)
        {
            const string LARGE = ">>>----->>";  // CONSTANTA const are always with CapitalLetters
            const string MEDIUM = ">>----->";
            const string SMALL = ">----->";

            string input;

            Dictionary<string, int> arrows = new Dictionary<string, int>()
            {
                {LARGE, 0},
                {MEDIUM, 0},
                {SMALL, 0},
            };

            Regex rgx = new Regex(@"(>>>----->>)|(>>----->)|(>----->)");

            for (int i = 0; i < 4; i++)
            {
                input = " " + Console.ReadLine() + " ";
                Match match = rgx.Match(input);

                while (match != Match.Empty)
                {
                    switch (match.Value)
                    {
                        case LARGE:
                            arrows[LARGE]++;
                            break;
                        case MEDIUM:
                            arrows[MEDIUM]++;
                            break;
                        case SMALL:
                            arrows[SMALL]++;
                            break;
                    }

                    match = match.NextMatch();
                }
            }

            uint result = uint.Parse(String.Format("{0}{1}{2}", arrows[SMALL], arrows[MEDIUM], arrows[LARGE]));
            string binary = Convert.ToString(result, 2);
            char[] arr = binary.ToCharArray();
            Array.Reverse(arr);
            binary += new string(arr);
            result = Convert.ToUInt32(binary, 2);

            Console.WriteLine(result);

        }
    }
}
