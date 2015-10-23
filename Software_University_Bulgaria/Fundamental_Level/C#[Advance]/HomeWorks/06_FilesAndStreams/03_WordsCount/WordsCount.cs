using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // Addint two Libraries
using System.Text.RegularExpressions;

namespace _03.WordsCount
{
    class WordsCount
    {
        static void Main(string[] args)
        {

            StreamReader readerText = new StreamReader("../../Text.txt");
            StreamReader readerWords = new StreamReader("../../words.txt");
            StreamWriter writer = new StreamWriter("../../result.txt");

            List<string> words = new List<string>();
            SortedDictionary<string, int> result = new SortedDictionary<string, int>();

            //First Part.Reading the files

            using (readerText)
            {
                using(readerWords)
                {
                    words = WordsToMatch(readerWords);
                    string line = readerText.ReadToEnd();

                    for (int i = 0; i < words.Count; i++)
                    {
                        string pattern = String.Format(@"\b{0}\b", words[i]);
                        Regex regex = new Regex(pattern,RegexOptions.IgnoreCase);
                        int numberOfTimes = 0; // the word is matched.
                        MatchCollection matches = regex.Matches(line);

                        foreach (var match in matches)
                        {
                            numberOfTimes++;
                        }

                        result.Add(words[i],numberOfTimes);
                    }

                }
            }


            // Second Part writing in the text file the result.
            using (writer)
            {
                foreach (var item in result.OrderByDescending(key => key.Value))
                {
                    writer.WriteLine("{0} - {1}",item.Key,item.Value);
                }
            }


        }

        private static List<string> WordsToMatch(StreamReader readerWords)
        {
            //Here filling the words that i need to chek with the Regex in a List.
            List<string> words = new List<string>();
            string lineOfWords = readerWords.ReadLine();

            while (lineOfWords != null) // taking the words in a List so it can easily be accessed.
            {
                string[] word = lineOfWords.Split(' ');

                for (int i = 0; i < word.Length; i++)
                {
                    words.Add(word[i]);
                }

                lineOfWords = readerWords.ReadLine();


            }

            return words;
        }
    }
}
