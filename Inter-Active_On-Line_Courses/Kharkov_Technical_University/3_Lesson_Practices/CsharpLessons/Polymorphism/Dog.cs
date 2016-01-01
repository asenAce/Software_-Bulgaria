using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Dog : Animal
    {
        public string name;
        public string owner;

        public override void move()
        {
            Console.WriteLine("Is Running");
        }



    }
}
