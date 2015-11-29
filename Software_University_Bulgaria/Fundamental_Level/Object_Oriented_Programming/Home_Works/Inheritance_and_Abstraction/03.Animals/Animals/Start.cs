using _03.aNIMALS.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animals
{
     internal class Program
    {
        static void Main(string[] args)
        {

            Animal[] animals =
            {
                new Cat(2,"Tonny",Gender.Male),
                new Dog(7,"Jonny",Gender.Male),
                new Frog(3,"Prince",Gender.Male),
                new Kitten(6,"Michel",Gender.Female),
                new TomCat(8,"Juddy",Gender.Male),
                new Dog(2,"Fred",Gender.Male),
            };

            var catsAverageAge = animals.Where(x => x is Cat).Average(x => x.Age);
            Console.WriteLine("The average of the all cats is : {0} ",catsAverageAge);

            var dogsAverageAge = animals.Where(x => x is Dog).Average(x => x.Age);
            Console.WriteLine("The average of the all dogs is : {0} ",dogsAverageAge);

            var frogAverageAge = animals.Where(x => x is Frog).Average(x => x.Age);
            Console.WriteLine("The average of the all frogs is : {0} ",frogAverageAge);

            var kittensAverageAge = animals.Where(x => x is Kitten).Average(x => x.Age);
            Console.WriteLine("The average of the all kittens is : {0} ",kittensAverageAge);

            var tomCatAverageAge = animals.Where(x => x is TomCat).Average(x => x.Age); // the atributes
            Console.WriteLine("The average of the all Tom Cats is : {0} ",tomCatAverageAge);



        }
    }
}
