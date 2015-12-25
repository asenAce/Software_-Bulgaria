using System;

class IntegerTypes
{
    static void Main()
    {
        byte centuries = 20;    // A small number (up to 255)
        ushort years = 2000;    // A small number (up to 32767)
        uint days = 730480;     // A large number (up to 4.3 billions)
        ulong hours = 17531520; // A very big number (up to 18.4*10^18)
        Console.WriteLine(
            "{0} centuries is {1} years, or {2} days, or {3} hours.",
            centuries, years, days, hours);
    }
}
