
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.aNIMALS.Animals
{
    class Frog : Animal
    {

        public Frog(int age,string name,Gender gender)
            :base(age,name,gender)
        {

        }


        public override void ProduceSound()
        {
            Console.WriteLine("The frog {0} says crack, ",this.Name);
        }

    }
}
