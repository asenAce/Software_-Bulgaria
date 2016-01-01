using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog Spot = new Dog();
            Spot.Age = 5;
            Spot.move();
            Spot.makeSomeNoice();
                

        }
    }
}
