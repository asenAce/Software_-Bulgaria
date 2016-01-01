using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(5);
            Console.WriteLine(numbers[0]);  //5

            List<string> titals = new List<string>();
            titals.Add("King");
            titals.Add("Qeen");
            titals.Add("Prince");
            titals.Add("Duck");

            List<string> cities = new List<string>();
            cities.Add("London");
            cities.Add("LiverPool");
            cities.Add("Brighton");

            List<string> castle = new List<string>();
            castle.Add("StrongHold");
            castle.Add("NomanKeep");
            castle.Add("stone manssion");

            //Example 

            List<string> name = new List<string>() { "Peter","Az","Todor"};
            name.Add("Nakov");

            name.RemoveAt(0);
            name.Insert(3,"Sisa");

            name[1] = "Micho";

            foreach ( var theName in name)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

            titals.Add("char");
            titals.RemoveAt(0);
            titals.Insert(2,"Vezir");

            titals[3] = "Sultan";

            foreach( var theTitle in titals)
            {
                Console.WriteLine(titals);
            }

            foreach( var theCities in cities)
            {
                Console.WriteLine(cities);
            }

        }
    }
}
