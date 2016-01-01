using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Peter","Maria","Katya","Mima"};
            string[] titles = { "King","Queen","Prince","Gerzok"};
            string[] casels = 
            { 
                "Royal","Noman Keep"," Keep Tower"
            };
            string[] forces = { "Navy"," Artilery"," Cavalry"};
            string[] cities = { "Town","vilage","Capital" };
            string[] currency = { "gold coins","copper coins","silver coins"};

            names.Reverse();

            names[0] = names[0] + "(Junior)";
            titles[3] = titles[3] + "(Worrior)";
            casels[2] = casels[2] + "(Stone)";
 
            foreach ( var name in names)
            {
                Console.WriteLine(names);
            }

            foreach( var title in titles)
            {
                Console.WriteLine(titles);
            }
            foreach( var castle in casels)
            {
                Console.WriteLine(casels);
            }

            Console.WriteLine(names);

            Console.ReadLine();

        }
    }
}
