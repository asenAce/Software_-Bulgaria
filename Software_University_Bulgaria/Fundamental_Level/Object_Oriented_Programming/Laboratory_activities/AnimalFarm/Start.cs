using AnimalFarm.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm
{
    class Start
    {
        static void Main(string[] args)
        {
            //numbers , adultKillos

            Pheasant pheasant = new Pheasant(0,0);
            pheasant.ProduceFood(0,0);
            

            Chicken chicken = new Chicken("Kokoshka",6);
            Console.WriteLine(chicken.GetHumanAge());
            Console.WriteLine(chicken.ProduceProduct());
            Console.WriteLine("end");
            
        }
    }
}
