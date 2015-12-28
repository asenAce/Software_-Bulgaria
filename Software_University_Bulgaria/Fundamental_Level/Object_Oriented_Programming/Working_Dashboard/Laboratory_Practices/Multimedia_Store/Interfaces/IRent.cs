namespace MultimediaShop.Interfaces
{
    using System;

    using MultimediaShop.Models;

    public interface IRent
    {
        IItem Item { get; }

        RentState RentState { get; }

        decimal RentFine { get; }

        void ReturnItem();
    }
}