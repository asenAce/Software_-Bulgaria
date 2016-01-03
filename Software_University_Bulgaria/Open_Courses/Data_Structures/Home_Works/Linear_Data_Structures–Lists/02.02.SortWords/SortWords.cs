using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02.SortWords
{
    class SortWords
    {
        static void Main(string[] args)
        {
            //VID
            //The Input
            //Take the value from the user and store it in the variable ID input
            string input = Console.ReadLine();
 

            //The Logic
            //Create a List<> with type string <> ID words with () parameters object input. method Split passing the 
            // parameters of the Split (' ') which means space between two characters.
            List<string> words = new List<string>(input.Split(' '));
            words.Sort();  // object word. method Sort () empty parameters 


            // PassThrow  variable word in each words which is a list 
            foreach (var word in words)
            {
                // Print on the Console. the ID words + " " empty space
                Console.WriteLine(words + " ");
            }

            //The Output

            Console.WriteLine();
        }
    }
}
