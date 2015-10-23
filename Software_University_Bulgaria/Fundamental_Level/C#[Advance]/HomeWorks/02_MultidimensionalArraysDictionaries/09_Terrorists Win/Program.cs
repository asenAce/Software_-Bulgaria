using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkNine.cs
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Input
            //Declare a Dictionary with several parameters string , and another dictionary SortedDictionary + another dictionary
            //SortedSet all of them of type strings... Matrioshka of Dictionary ;-)
            Dictionary<string, SortedDictionary<string, SortedSet<string>>> nightLifeDictionary =
                new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();

            string[] eventTokens;  // Declare an Array of strings ID eventTokens;

            string city = string.Empty;
            string venue = string.Empty;
            string performer = string.Empty;

            Console.WriteLine("Information for the Event: "); // Promp the user...
            string eventInformation = Console.ReadLine();  // Take the information from the Console and stored into ID eventInformation 
            // TYPE string 

            #endregion Input

            #region Logic

            while (eventInformation != "END")  // Test is eventInformation contain the word END  if not enter this block of code.
            {
                // from right to left Remove Empty Entries after the String Split Options separeted by ; {';'} look for this character
                // then all the rafinated data store into the new created Array of type char [] all the data came from the ID eventInformation
                // after is Split -ed  eventInformation is an Object and the Split is a method of this object it is called by
                // the dot seporetor and all this go into the eventTokens for later use....
                eventTokens = eventInformation.Split(new char[] {';'},StringSplitOptions.RemoveEmptyEntries);

                city = eventTokens[0];  // eventTokens[] possition in this case 0
                venue = eventTokens[1];
                performer = eventTokens[2];

                if (!nightLifeDictionary.ContainsKey(city)) // Check the condition : ! if not
                {
                    nightLifeDictionary[city] = new SortedDictionary<string, SortedSet<string>>(); // the two Dictionaries
                }

                if (!nightLifeDictionary.ContainsKey(venue))
                {
                    nightLifeDictionary[city][venue] = new SortedSet<string>();
                }

                nightLifeDictionary[city][venue].Add(performer); // Add a performer to the nightLifeDictionary

                eventInformation = Console.ReadLine();
            }

            foreach (var cityPair in nightLifeDictionary)  // first literation
            {
                Console.WriteLine(cityPair.Key);

                foreach (var venuePair in cityPair.Value)
                {
                    Console.WriteLine("-> {0} : {1}",venuePair.Key,string.Join(",",venuePair.Value));
                }
            }

            #endregion Logic

            #region Output
            #endregion Output


        }
    }
}
