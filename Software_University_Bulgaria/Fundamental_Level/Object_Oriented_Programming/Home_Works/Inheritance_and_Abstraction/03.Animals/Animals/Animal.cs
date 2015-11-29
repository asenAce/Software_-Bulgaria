using _03.aNIMALS.IContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.aNIMALS.Animals
{
   abstract class Animal : ISound 
    {

       private string name;
       private int age;

       public Animal(int age,string name,Gender gender)
       {
           this.Age = age;
           this.Name = name;
           this.Gender = gender;
       }

       public int Age 
       {
           get
           {
               return this.age;
           }
           set
           {
               if (value < 0 )
               {
                   throw new ArgumentOutOfRangeException("Incorrect");
               }

               this.age = value;
           }
       }

       public string Name 
       { 
           get
           {
               return this.name;
           }
           set
           {
               if (string.IsNullOrEmpty(value))
               {
                   throw new ArgumentNullException("Incorrect");
               }
               this.name = value;
           }
       }

       public Gender Gender { get; set; }

       public abstract void ProduceSound();

    }
}
