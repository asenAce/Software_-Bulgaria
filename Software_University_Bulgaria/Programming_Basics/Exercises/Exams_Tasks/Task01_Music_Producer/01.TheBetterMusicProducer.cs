using System;

class TheBetterMusicProducer
{
    static void Main()
    {
        int albumsEurope = int.Parse(Console.ReadLine());
        decimal albumPriceEurope = decimal.Parse(Console.ReadLine());

        int albumsNAmerika = int.Parse(Console.ReadLine());
        decimal albumPriceNAmerika = decimal.Parse(Console.ReadLine());

        int albumsSAmerika = int.Parse(Console.ReadLine());
        decimal albumPriceSAmerika = decimal.Parse(Console.ReadLine());

        int concertsCount = int.Parse(Console.ReadLine());
        decimal incomesPerConcerts = decimal.Parse(Console.ReadLine());

        decimal totalAlbumIncomes = 0;
        
        totalAlbumIncomes += (albumPriceEurope*albumsEurope) * 1.94M;
        totalAlbumIncomes += (albumPriceNAmerika * albumsNAmerika) * 1.72M;
        totalAlbumIncomes += (albumPriceSAmerika * albumsSAmerika) / 332.74M;
        
        totalAlbumIncomes *= 0.65M;
        totalAlbumIncomes *= 0.8M;

        decimal totalConcertsIncomes = (concertsCount*incomesPerConcerts)*1.94M;

        if (totalConcertsIncomes > 100000.00M)
        {
            totalConcertsIncomes *= 0.85M;
        }

        if (totalConcertsIncomes >= totalAlbumIncomes)
        {
            Console.WriteLine("On the road again! We'll see the world and earn {0:F2}lv.", totalConcertsIncomes);
        }
        else
        {
            Console.WriteLine("Let's record some songs! They'll bring us {0:F2}lv.", totalAlbumIncomes);
        }
    }
}