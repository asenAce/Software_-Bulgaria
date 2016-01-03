using System;

using C5;

class IntervalHeapExample
{
    static void Main()
    {
        var people = new IntervalHeap<Person>();
        people.Add(new Person("Nakov", 25));
        people.Add(new Person("Petya", 24));
        people.Add(new Person("Pesho", 25));
        people.Add(new Person("Maria", 22));
        people.Add(new Person("Ivan", -1));
        Console.WriteLine("Min: {0}", people.FindMin());
        Console.WriteLine("Max: {0}", people.FindMax());
        while (people.Count > 0)
        {
            Console.WriteLine(people.DeleteMin());
        }
    }
}
