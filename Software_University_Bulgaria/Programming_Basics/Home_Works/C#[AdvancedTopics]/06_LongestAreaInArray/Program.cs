using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _
{
    class Program06.LongestAreaInArray
    {

        /**
          * Write a program to find the longest area of equal elements in array of strings. You first should read an integer n and n strings
          * (each at a separate line), then find and 
          * print the longest sequence of equal elements (first its length, then its elements). If multiple sequences have 
          * the same maximal length, print the leftmost of them. 
          * 
          * */
        static void Main(string[] args)
        {
            int arryLenght = int.Parse(Console.ReadLine());

            string[] words = new string[arrayLenght];

            for ( int i =0; i< words.Length,i++)
            {
                string arryElements = Console.ReadLine();
                words[i] = arryElements;
            }

            int startIndex = 0;
            int lenghtCount = 1;
            int currentCount = 1;

            for ( int i = 0; i < words.Length-1;i++)
                //Could start on index 1 and check current with previous elements.
            {
                if( words[i] == words[i + 1])
                {
                    currentCount++;

                    if( currentCount > lenghtCount)
                    {
                        lenghtCount = currentCount;
                        startIndex = (i + 1) - (lenghtCount - 1);
                    }
                }

                else
                {
                    currentCount =1;
                }
            }

            Console.WriteLine(lenghtCount);
            for( int i = 0; i < lenghtCount; i++)
            {
                Console.WriteLine(words[startIndex + i]);
            }

        }
    }
}
