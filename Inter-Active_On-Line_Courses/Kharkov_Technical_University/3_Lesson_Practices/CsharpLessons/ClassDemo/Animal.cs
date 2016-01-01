using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classDemo
{
    class Animal
    {

        private string type;          // private means that only a code with in thos code can modify this variables!
        private string color;         // Those are atributes basiclly characteristics of the class Animal!   
        private string weight;
        private string height;
        private int age;
        private int numOfLegs;


        //Now we create some functionalaty to our class,come methods! Also those are Functions that i order to use them ,we call them from
        // main() 
        public void move() // This is the first Function
        {
            Console.WriteLine("Move");
        }

        public void makeSomeNoice() //This is the second function!
        {

        }


    }
}
