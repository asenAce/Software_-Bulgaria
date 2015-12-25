using System;

class TryParseExample
{
    static void Main()
    {
        try 
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number.");
        }


        Console.WriteLine("Bye from me.");
    }
}
