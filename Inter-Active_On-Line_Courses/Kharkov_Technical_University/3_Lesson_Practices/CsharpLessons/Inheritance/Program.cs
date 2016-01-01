using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance 
            // namespace is a logical container for classes! , control the classes in large projects,
            //Prevent duplicate class names when using multiple vendors' code. C# provides the using derective to help shorten
            // namespace.class.method typing in code!
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog Spot = new Dog();
            Spot.move();
        }
    }
}
