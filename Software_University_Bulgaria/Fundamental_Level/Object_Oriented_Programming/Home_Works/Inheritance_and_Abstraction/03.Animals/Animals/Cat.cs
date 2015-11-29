using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.aNIMALS.Animals
{
    class Cat : Animal
    {

        public Cat(int age, string name,Gender gender)
            :base(age,name,gender)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("The cat {0} says: Mayyy",this.Name);
        }

    }
}
