using System;

class PriorityQueueExample
{
    static void Main()
    {
        var people = new PriorityQueue<Person>();
        people.Enqueue(new Person("Nakov", 25));
        people.Enqueue(new Person("Petya", 24));
        people.Enqueue(new Person("Pesho", 25));
        people.Enqueue(new Person("Maria", 22));
        people.Enqueue(new Person("Ivan", int.MinValue));
        while (people.Count > 0)
        {
            Console.WriteLine(people.Dequeue());
        }
    }
}