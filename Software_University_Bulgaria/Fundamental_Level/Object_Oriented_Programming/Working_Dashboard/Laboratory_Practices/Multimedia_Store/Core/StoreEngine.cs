namespace MultimediaShop.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    using MultimediaShop.Interfaces;
    using MultimediaShop.Models.Items;
    using MultimediaShop.Exceptions;

    public class StoreEngine
    {
        private const string DateTimeFormat = "dd-MM-yyyy";

        private IDictionary<IItem, int> supplies;

        public StoreEngine()
        {
            this.supplies = new Dictionary<IItem, int>();
        }

        public void Run()
        {
            while (true)
            {
                string inputUrl = Console.ReadLine();
                string[] commandArgs = inputUrl.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                switch (commandArgs[0])
                {
                    case "supply":
                        {
                            string type = commandArgs[1];
                            int quantity = int.Parse(commandArgs[2]);
                            string paramsString = commandArgs[3];

                            this.ExecuteSupplyCommand(type, paramsString, quantity);
                            break;
                        }
                    case "sell":
                        {
                            string id = commandArgs[1];
                            var item = this.GetItemById(id);
                            var saleDate = ToDateTime(commandArgs[2]);

                            this.ExecuteSellCommand(item, saleDate);
                            break;
                        }
                    case "rent":
                        {
                            string id = commandArgs[1];
                            var item = this.GetItemById(id);
                            var rentDate = ToDateTime(commandArgs[2]);
                            var deadline = ToDateTime(commandArgs[3]);
 
                            this.ExecuteRentCommand(item, rentDate, deadline);
                            break;
                        }
                    case "report":
                        {
                            this.ExecuteReportCommand(commandArgs);
                            break;
                        }
                    case "return":
                        // TODO: Requires customer implementation
                        throw new NotImplementedException("Returning items is not implemented yet.");
                    default:
                        throw new InvalidOperationException("Invalid command.");
                } 
            }
        }

        private void ExecuteReportCommand(string[] commandArgs)
        {
            string reportType = commandArgs[1];
            switch (reportType)
            {
                case "sales":
                    DateTime startDate = ToDateTime(commandArgs[2]);
                    decimal salesIncome = SaleManager.ReportSalesIncome(startDate);

                    Console.WriteLine(string.Format("{0:F2}", salesIncome));
                    break;
                case "rents":
                    var overdueRents = RentManager.ReportOverdueRents();

                    Console.WriteLine(string.Join("\n", overdueRents));
                    break;
                default:
                    throw new ArgumentException("Invalid report type.");
            }
        }

        private void ExecuteRentCommand(IItem item, DateTime rentDate, DateTime deadline)
        {
            if (this.supplies[item] == 0)
            {
                throw new InsufficientSuppliesException("There are not enough supplies to sell this item.");
            }

            RentManager.AddRent(item, rentDate, deadline);
            this.supplies[item]--;
        }

        private void ExecuteSellCommand(IItem item, DateTime saleDate)
        {
            if (this.supplies[item] == 0)
            {
                throw new InsufficientSuppliesException("There are not enough supplies to sell this item.");
            }

            SaleManager.AddSale(item, saleDate);
            this.supplies[item]--;
        }

        private void ExecuteSupplyCommand(string itemType, string paramsString, int quantity)
        {
            var itemParams = GetItemParams(paramsString);

            switch (itemType)
            {
                case "book":
                    {
                        string id = itemParams["id"];
                        string title = itemParams["title"];
                        string author = itemParams["author"];
                        decimal price = decimal.Parse(itemParams["price"]);
                        string genre = itemParams["genre"];

                        var book = new Book(id, title, price, author, genre);
                        this.AddToSupplies(book, quantity);
                        break;
                    }
                case "video":
                    {
                        string id = itemParams["id"];
                        string title = itemParams["title"];
                        decimal price = decimal.Parse(itemParams["price"]);
                        string genre = itemParams["genre"];
                        int length = int.Parse(itemParams["length"]);

                        var video = new Video(id, title, price, length, genre);
                        this.AddToSupplies(video, quantity);
                        break;
                    }
                case "game":
                    {
                        string id = itemParams["id"];
                        string title = itemParams["title"];
                        decimal price = decimal.Parse(itemParams["price"]);
                        string genre = itemParams["genre"];
                        AgeRestriction ageRestriction = ToEnum(itemParams["ageRestriction"]);

                        var game = new Game(id, title, price, genre, ageRestriction);
                        this.AddToSupplies(game, quantity);
                        break;
                    }
                default:
                    throw new ArgumentException("Invalid item type.");
            }
        }

        private void AddToSupplies(IItem item, int quantity)
        {
            if (!this.supplies.ContainsKey(item))
            {
                this.supplies[item] = 0;
            }

            this.supplies[item] += quantity;
        }

        private static IDictionary<string, string> GetItemParams(string paramsString)
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            string[] pairs = paramsString.Split('&');

            foreach (var pair in pairs)
            {
                string[] keyValuePair = pair.Split('=');
                keyValuePairs[keyValuePair[0]] = keyValuePair[1];
            }

            return keyValuePairs;
        }

        private static DateTime ToDateTime(string dateString)
        {
            return DateTime.ParseExact(dateString, DateTimeFormat, CultureInfo.InvariantCulture);
        }

        private static AgeRestriction ToEnum(string enumString)
        {
            return (AgeRestriction)Enum.Parse(typeof(AgeRestriction), enumString);
        }

        private IItem GetItemById(string id)
        {
            return this.supplies
                .First(x => x.Key.Id == id)
                .Key;
        }
    }
}
