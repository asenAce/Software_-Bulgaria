namespace MultimediaShop.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using MultimediaShop.Interfaces;
    using MultimediaShop.Models;

    public static class RentManager
    {
        private static ISet<IRent> rents = new HashSet<IRent>();

        public static void AddRent(IItem item, DateTime rentDate, DateTime deadline)
        {
            rents.Add(new Rent(item, rentDate, deadline));
        }

        public static IEnumerable<IRent> ReportOverdueRents()
        {
            return rents
                .Where(r => r.RentState == RentState.Overdue)
                .OrderBy(r => r.RentFine)
                .ThenBy(r => r.Item.Title);
        }
    }
}
