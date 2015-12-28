using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm.Animals
{
    class Chicken : Animal
    {

       public Chicken(string name,int age)
           :base(name,age)
       {

       }

       public override Product ProduceProduct()
       {
           return new Product();
       }



        public override double GetHumanAge()
        {
            int theResult;

            theResult = this.age * 11;

            return theResult;
        }
    }
}
