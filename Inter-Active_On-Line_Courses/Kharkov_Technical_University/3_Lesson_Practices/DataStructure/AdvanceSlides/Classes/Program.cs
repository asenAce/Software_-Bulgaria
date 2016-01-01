using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesOne
{
    class Program : Person
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Young people: ");

            foreach (var p in people)
            {
                if (p.Age < 50)
                {
                    Console.WriteLine("{0} (age:  {1})", p.LastName, p.Age);
                }
            }

            var youngPeople = people.Where(p => p.Age < 50);

            foreach ( var p in youngPeople)
            {
                Console.WriteLine("{0} (age:  {1})",p.LastName,p.Age);
            }

        }
    }
}
