namespace MultimediaShop.Models
{
    using System;

    using MultimediaShop.Interfaces;

    public class Sale : ISale
    {
        private IItem item;

        public Sale(IItem item)
            : this(item, DateTime.Now)
        {
        }

        public Sale(IItem item, DateTime saleDate)
        {
            this.Item = item;
            this.SaleDate = saleDate;
        }

        public IItem Item
        {
            get
            {
                return this.item;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Item cannot be null.");
                }

                this.item = value;
            }
        }

        public DateTime SaleDate { get; set; }

        public override string ToString()
        {
            return string.Format("- {0} {1}\n{2}",
                this.GetType().Name, this.SaleDate, this.Item);
        }
    }
}
