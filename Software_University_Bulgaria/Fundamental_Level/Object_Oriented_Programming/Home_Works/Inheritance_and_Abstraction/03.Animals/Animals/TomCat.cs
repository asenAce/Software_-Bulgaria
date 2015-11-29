
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.aNIMALS.Animals
{
    class TomCat : Animal
    {

        public TomCat(int age,string name,Gender gender)
            :base(age,name,gender)
        {

        }


        public override void ProduceSound()
        {
            Console.WriteLine("The big Cat {0} says, Hello Baby want to play with me ....",this.Name);
        }

    }
}
