using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.aNIMALS.Animals
{
    class Dog :  Animal
    {

        public Dog(int age,string name,Gender gender)
            :base(age,name,gender)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("The dog {0} says: Bauuu",this.Name);
        } 

    }
}
