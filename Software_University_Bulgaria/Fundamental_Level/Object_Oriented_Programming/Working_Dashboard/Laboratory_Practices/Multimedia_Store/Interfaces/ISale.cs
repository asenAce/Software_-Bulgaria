namespace MultimediaShop.Interfaces
{
    using System;

    public interface ISale
    {
        IItem Item { get; }

        DateTime SaleDate { get; }
    }
}
