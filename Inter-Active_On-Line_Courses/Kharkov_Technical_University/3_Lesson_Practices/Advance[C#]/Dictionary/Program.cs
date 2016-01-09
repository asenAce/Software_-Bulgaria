using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            phonebook["John Smith"] = "+1 - 455-7888";      // key , value
            phonebook["Lisa Liska"] = "+1- 887-8999";
            phonebook["Sam sam "] = "+1- 887-9877";
            phonebook["Nakk"] = "+1-675-3422";

            phonebook.Remove("John Smith");

            foreach ( var entry in phonebook) 
            {
                Console.WriteLine("{0} --> {1}",entry.Key,entry.Value);     //entry.Key, entry.Value
            }
            Console.ReadLine();

        }
    }
}
