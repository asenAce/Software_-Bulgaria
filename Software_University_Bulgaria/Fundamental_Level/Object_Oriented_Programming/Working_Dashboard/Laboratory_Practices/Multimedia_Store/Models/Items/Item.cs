namespace MultimediaShop.Models.Items
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using MultimediaShop.Interfaces;

    public abstract class Item : IItem
    {
        private string id;
        private decimal price;
        private string title;

        protected Item(string id, string title, decimal price, IList<string> genres)
        {
            this.Id = id;
            this.Title = title;
            this.Price = price;
            this.Genres = genres;
        }

        protected Item(string id, string title, decimal price)
            : this(id, title, price, new List<string>())
        {
        }

        public string Id 
        {
            get
            {
                return this.id;
            }
            private set
            { 
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Id cannot be null or empty.");
                }

                if (value.Length < 4)
                {
                    throw new ArgumentOutOfRangeException("Id must be at least 4 characters long.");
                }

                this.id = value;
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Title cannot be null or empty.");
                }

                this.title = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative.");
                }

                this.price = value;
            }
        }

        public IList<string> Genres { get; private set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("{0} {1}", this.GetType().Name, this.Id));
            result.AppendLine(string.Format("Title: {0:F2}", this.Title));
            result.AppendLine(string.Format("Price: {0:F2}", this.Price));
            result.AppendLine(string.Format("Genres: {0}", string.Join(", ", this.Genres)));

            return result.ToString();
        }
    }
}