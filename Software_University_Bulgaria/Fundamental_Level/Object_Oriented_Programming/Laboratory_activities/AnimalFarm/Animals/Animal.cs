using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm.Animals
{
   public abstract class Animal
    {

       private const int MINANIMALAGE = 0;
       private const int MAXANIMALAGE = 15;

       private string name;
       protected int age;

       public Animal()
       {

       }

       public Animal(string name,int age)
       {
           this.Name = name;
           this.Age = age;
       }


       public string Name { get; protected set; }
       public int Age 
       {
           get
           {
               return this.age;
           }
           set
           {
               if (value < 0)
               {
                   throw new ArgumentOutOfRangeException("Incorrect");
               }
               this.age = value;
           }
       }

       public double ProductionPerDay 
       {
           get
           {
               return this.CalculateTheProduce();
           }

       }

       public abstract double GetHumanAge();

       public abstract Product ProduceProduct();

       public double CalculateTheProduce()
       {

           switch (this.age)
           {
               case 0:
               case 1:
               case 2:
               case 3:
                   return 1.5;
               case 4:
               case 5:
               case 6:
               case 7:
                   return 2;
               case 8:
               case 9:
               case 10:
               case 11:
                   return 1;

               default:
                   return 0.75;
           }


       }




    }
}
