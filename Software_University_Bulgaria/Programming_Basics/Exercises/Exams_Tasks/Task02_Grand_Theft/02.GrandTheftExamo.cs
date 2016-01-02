using System;

class GrandTheftExamo
{
    static void Main()
    {
        int attempts = int.Parse(Console.ReadLine());

        long thievesSlapped = 0;
        long thievesEscaped = 0;
        long totalBeers = 0;

        for (int i = 0; i < attempts; i++)
        {
            int thieves = int.Parse(Console.ReadLine());
            int beers = int.Parse(Console.ReadLine());

            if (thieves > 5)
            {
                thievesEscaped += thieves - 5;
                thievesSlapped += 5;
                totalBeers += beers;
            }
            else
            {
                thievesSlapped += thieves;
                totalBeers += beers;
            }
        }
        Console.WriteLine("{0} thieves slapped.", thievesSlapped);
        Console.WriteLine("{0} thieves escaped.", thievesEscaped);
        Console.WriteLine("{0} packs, {1} bottles.", totalBeers / 6, totalBeers % 6);
    }
}