using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskThree.cs
{
    class SubstringCount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input ");
            string input = Console.ReadLine().ToLower();

            Console.WriteLine("Phrase");
            string phrase = Console.ReadLine().ToLower();

            Console.WriteLine(SubstringMatches(input,phrase));

        }


        static int SubstringMatches(string toMatch,string substring)    // taking parameters ... & Method...
        {
            int lastIndex = 0;
            int count = 0;

            while (true)
            {
                lastIndex = toMatch.IndexOf(substring,lastIndex);

                if (lastIndex == -1)
                {
                    break;
                }

                else
                {
                    lastIndex++;
                    count++;
                }

                

            }

            return count;

        }

    }
}
