using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Animal
    {
        // Declare the variables
        private string type;          // private means that only a code with in those code can modify this variables!
        private string color;         // Those are atributes bassicly characteristics of the class Animal!   
        private string weight;
        private string height;
        private int age;               //The variable is with a lower case!
        private int numOfLegs;         // Access modefier ; type ; Idenefier ID

        //  Creating Get-ers and Set-ers / properties
        public int Age    // But the property is with a Capital Letter!
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                //If statement  in the () is the condition! it is a logical construction to make sure that the user do not
                // put  - value , number!
                {
                    Console.WriteLine("Invalide");
                    Console.Read();
                }
                else
                {
                    this.age = value; // A sign the value!
                }

            }
        }

        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }



        //Now we create some functionalaty to our class,some methods! Also those are Functions that i order to use them ,we call them from
        // main() 
        public void move() // This is the first Function
        {
            Console.WriteLine("Move");
        }

        public void makeSomeNoice() //This is the second Function!
        {

        }


    }
}
