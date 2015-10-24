using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.LongestAreaInArrayTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to find the longest area of equal elements in array of strings. You first should read an integer n and n strings (each at a separate line), then find and print the longest sequence of equal elements (first its length, then its elements). If multiple sequences have the same maximal length, print the leftmost of them");
            Console.WriteLine("Write how many string will hold the array: ");

            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> array = new Dictionary<string, int>();
            Console.WriteLine("Write {0}  string:  ",n);

            //Fill the dictionary with words as key and times met as value.
            for (int i = 0; i < n; i++ )
            {
                Console.WriteLine("Write string {0}",i+1);
                String word = Console.ReadLine();

                if(!array.ContainsKey(word))
                {
                    array.Add(word,1);
                }
                else
                {
                    array[word]++;
                }
            }

            int maxCount = array.Values.Max();

            //fill list with the most common words.
            List<string> list = new List<string>();
            foreach( string word in array.Keys)
            {
                if(!list.Contains(word) && array[word] == maxCount)
                {
                    list.Add(word);
                }
            }
            string mostCommonWord = list[0];
            Console.WriteLine("The word {0} is met {1} times. " , mostCommonWord,maxCount);

            Console.ReadLine();
        }
        
    }
    
}
