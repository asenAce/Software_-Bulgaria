using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal newAnimal = new Animal();    // We create a instance of this animal as we create new,to instanciate a class we use a word new
            newAnimal.move();
            Console.Read();
        }
    }
}
