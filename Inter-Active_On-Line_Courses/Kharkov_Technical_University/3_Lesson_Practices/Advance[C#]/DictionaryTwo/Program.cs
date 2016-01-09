using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<DateTime, string> events = new Dictionary<DateTime, string>();

            events[new DateTime(1998, 9, 4)] = "Google is born";
            events[new DateTime(2013,11,5)]="SoftUni was created";
            events[new DateTime(1975,4,4)]="Microsoft birthday";
            events[new DateTime(2004,2,4)] = "Facebook birthday";
            events[new DateTime(2013,11,5)]="Nakov left";

            foreach(var entry in events)
            {
                Console.WriteLine("{0:dd-MMM-yyyy}: {1}",entry.Key,entry.Value);
            }
            Console.ReadLine();
        }
    }
}
