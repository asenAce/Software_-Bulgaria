using System;

class Program
{
    static void Main()
    {
        uint priceInR = uint.Parse(Console.ReadLine());
        uint priceInD = uint.Parse(Console.ReadLine());
        uint priceInE = uint.Parse(Console.ReadLine());
        uint priceInB = uint.Parse(Console.ReadLine());
        uint priceInM = uint.Parse(Console.ReadLine());

        decimal R = (priceInR  100M  3.5M);
        decimal D = (priceInD  1.5M);
        decimal E = (priceInE  1.95M);
        decimal B = (priceInB  2M);

        Console.WriteLine({0F2}, Math.Ceiling(Math.Max(R, Math.Max(D, Math.Max(E, Math.Max(B, priceInM))))));
    }
}