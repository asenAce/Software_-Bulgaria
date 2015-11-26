using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LapTopShop
{
   public class LapTop
    {

        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string hdd;
        private string graphicsCard;
        private Battery battery;
        private string screen;
        private decimal price;


        public LapTop(string model,decimal price)
        {
            this.Model = model;
            this.Price = price;
        }

        public LapTop(string model, decimal price, string manufacturer = null,string processor = null,string ram = null,string hdd = null,
            string graphicsCard = null,Battery battery = null,string screen = null) : this(model,price)                                     
        {
            this.Model = model;
            this.Price = price;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.Hdd = hdd;
            this.GraphicsCard = graphicsCard;
            this.Battery = battery;
            this.Screen = screen;
      
        }

        public string  Model 
        {
            get
            {
                return this.model;
            }
            set
            {
                // Except handling check the string is it a null or empty    check this (value) passing the parameters!
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Incorrect !!");
                }
                this.model = value;
            }
        }

        public string Manufacturer  
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("Incorrect!!");
                }
                this.manufacturer = value;
            }
        }

        public string Processor 
        {
            get
            {
                return this.processor;
            }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("Incorrect !!");
                }
                this.processor = value;
            }
        }

        public string Ram 
        {
            get
            {
                return this.ram;
            }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("Incorrect !!");
                }
                this.ram = value;
            }
        }

        public string  Hdd 
        {
            get
            {
                return this.hdd;
            }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("Incorrect !!");
                }
                this.hdd = value;
            }
        }

        public string GraphicsCard 
        {
            get
            {
                return this.graphicsCard;
            }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("Incorrect !!");
                }
                this.graphicsCard = value;
            }
        }


        public Battery Battery 
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public string  Screen 
        {
            get
            {
                return this.screen;
            }
            set
            {
                if (value != null && value.Length < 1)
                {
                    throw new ArgumentException("Incorrect !!");
                }
                this.screen = value;
            }
        }

        public decimal  Price 
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0 )
                {
                    throw new ArgumentException("Incorrect !!");
                }
                this.price = value;
            }
        }

        // ToString Method!
        public override string ToString()
        {
            StringBuilder laptopStr = new StringBuilder();
            laptopStr.AppendLine("model : " + this.Model);

            //Logic using if loop
            if (this.Manufacturer != null)
            {
                laptopStr.AppendLine("Manufacturer : " + this.Manufacturer);
            }
            if (this.Processor != null)
            {
                laptopStr.AppendLine("Processor: " + this.Processor);
            }
            if (this.Ram != null)
            {
                laptopStr.AppendLine("RAM: " + this.Ram);
            }
            if (this.Hdd != null)
            {
                laptopStr.AppendLine("HDD: " + this.Hdd);
            }
            if (this.GraphicsCard != null)
            {
                laptopStr.AppendLine("GraphicsCard: " + this.GraphicsCard);
            }
            if (this.Battery != null)
            {
                laptopStr.Append(this.Battery.ToString());
            }
            if (this.Screen != null)
            {
                laptopStr.AppendLine("Screen: " + this.Screen);
            }
            laptopStr.AppendLine("Price: " + this.Price);
            return laptopStr.ToString();
        }




    }
}
