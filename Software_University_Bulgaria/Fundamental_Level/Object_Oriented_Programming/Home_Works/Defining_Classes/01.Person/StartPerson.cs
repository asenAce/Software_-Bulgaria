using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Person
{
    class StartPerson
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>()
            {
                new Person("Ivan ",45),
                new Person("Mitko",24,"neshtosi@abv.bg"),
                new Person("Hristo",14,"neshtosi2@abv.bg"),
            };

            persons.ForEach(p => Console.WriteLine(p.ToString()));

        }
    }
}
