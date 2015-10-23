using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkEight.cs
{
    class Program
    {
        /*
         * Phone book.
         * */

        static void Main(string[] args)
        {
            #region The Input
            Dictionary<string, List<string>> phonebook = new Dictionary<string, List<string>>(); // Craeting a Dictionary<> 
            //two parameters first string, second generic list<>

            string input; // string ID input
            string[] contact; // Array

            #endregion The Input

            #region The Logic
            while (!((input = Console.ReadLine()) == "search"))
            {
                contact = input.Split('-');

                if (!phonebook.Keys.Contains(contact[0]))
                {
                    phonebook[contact[0]] = new List<string>();
                }

                phonebook[contact[0]].Add(contact[1]);
            }
            // if input is the word search
            if (input == "search")
            {
                while (!((input = Console.ReadLine()) == "END")) // but diferend from END
                {
                    if (phonebook.Keys.Contains(input)) // make iteration...
                    {
                        foreach (var phone in phonebook[input])
                        {
                            Console.WriteLine("{0} -> {1}",input,phone);
                        }
                    }

                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.",input);
                    }
                }
            }

            #endregion The Logic

            #region OutPut
            #endregion OutPut


        }
    }
}
