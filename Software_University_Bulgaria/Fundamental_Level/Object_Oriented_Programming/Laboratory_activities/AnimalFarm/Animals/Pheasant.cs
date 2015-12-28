using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm.Animals
{
     class Pheasant : Animal
    {
        //numbers , adultKillos
      public  int numbers;
      public  int adultKillos;


        public Pheasant()
        {

        }

        public Pheasant(string name,int age)
            :base(name,age)
        {

        }

        public Pheasant(int numbers, int adultKillos)
        {
            this.Numbers = numbers;
            this.AdultKillos = adultKillos;

        }

        public int Numbers 
        {
            get
            {
                return this.numbers;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Incorrect");
                }
                this.numbers = value;
            }
        }
        public int AdultKillos 
        {
            get
            {
                return this.adultKillos;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Incorret");
                }
                this.adultKillos = value;
            }
        }



        public override double GetHumanAge()
        {
            int theResult;

            theResult = this.age * 7;

            return theResult;
        }

        public int ProduceFood(int numbers, int adultKillos)
        {
            int result;
            int numbersInput;
            const int adultKillosInput = 12;

            Console.WriteLine("numbers = ");
            numbersInput = int.Parse(Console.ReadLine());


            result = numbersInput * adultKillosInput;
            Console.WriteLine("The Farm will produce {0} Kg. of meat ",result);

            return result;
        }

        public override Product ProduceProduct()
        {
            return new Product();
        }
    }
}
