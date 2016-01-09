using ConsoleAppTwo.Model;
using System;
using System.Collections.Generic;

namespace ConsoleAppTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            var produce = new List<object>();

            var f1 = new Fruit("Apple",8.5,3);
           // f1.Name = "Apple";
           // f1.Weight = 4.6;
           // f1.Quantity = 3;
            produce.Add(f1);

            var f2 = new Vegetable();
            f2.Name = "Bananna";
            f2.Weight = 4.9;
            f2.Quantity = 7;
            produce.Add(f2);

            produce.Add(new Vegetable());
            ((Vegetable)produce[2]).Name = "Carrot";
            ((Vegetable)produce[2]).Weight = 9.6;
            ((Vegetable)produce[2]).Quantity = 14;

            Console.WriteLine("There are "+produce.Count+" items");

            foreach (var item in produce)
            {
                Console.WriteLine(item);
            }

        }
    }


    //class Fruit
    //{
    //    public Fruit()
    //    {

    //    }

    //    public Fruit(string name,double weight,int quantity)
    //    {
    //        Name = name;
    //        Weight = weight;
    //        Quantity = quantity;

    //    }

    //    private string name;
    //    public string Name //Property get extendefier , set modifaer 
    //    {
    //        get { return name.ToUpper(); }  // Methods 
    //        set { name = value; }
    //    }

    //    private double weight;
    //    public double Weight
    //    {
    //        get { return weight; }
    //        set { weight = value; }
    //    }

    //    public int Quantity { get; set; }

    //    public override string ToString()
    //    {
    //        return name + "(" + Weight + "oz) :" + Quantity;
    //    }

    //}

    
}
