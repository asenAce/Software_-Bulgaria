using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.aNIMALS.Animals
{
    class Kitten : Animal
    {

        public Kitten(int age,string name,Gender gender)
            : base(age,name,gender)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("The Kitten {0} says ouuuu",this.Name);
        }

    }
}
