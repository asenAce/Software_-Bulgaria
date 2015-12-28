namespace MultimediaShop.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using MultimediaShop.Interfaces;
    using MultimediaShop.Models;

    public static class SaleManager
    {
        private static ISet<ISale> sales = new HashSet<ISale>();
        
        public static void AddSale(IItem item, DateTime dateTime)
        {
            sales.Add(new Sale(item, dateTime));
        }

        public static decimal ReportSalesIncome(DateTime startDate)
        {
            return sales
                .Where(s => s.SaleDate >= startDate)
                .Sum(s => s.Item.Price);
        }
    }
}
