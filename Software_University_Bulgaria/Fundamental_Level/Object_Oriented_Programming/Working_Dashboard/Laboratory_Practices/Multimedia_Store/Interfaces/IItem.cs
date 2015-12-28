namespace MultimediaShop.Interfaces
{
    using System;
    using System.Collections.Generic;

    public interface IItem 
    {
        string Id { get; }

        string Title { get; }

        decimal Price { get; }

        IList<string> Genres { get; }
    }
}
