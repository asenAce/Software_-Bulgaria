using System;

class PrintingLetter
{
    static void Main()
    {
        Console.Write("Enter person name: ");
        string person = Console.ReadLine();

        Console.Write("Enter company name: ");
        string company = Console.ReadLine();

        Console.WriteLine("  Dear {0},", person);
        Console.WriteLine("We are pleased to tell you that " +
          "{1} has accepted you to take part in the \"C# Basics\"" +
          " course. {1} wishes you a good luck!", person, company);

        Console.WriteLine("  Yours,");
        Console.WriteLine("  {0}", company);
    }
}
