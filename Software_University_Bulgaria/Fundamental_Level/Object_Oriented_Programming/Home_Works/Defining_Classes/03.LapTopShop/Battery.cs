using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LapTopShop
{
    class Battery
    {
        // Defining the data fields
        private string type;
        private float  hours;

        // Ctor constructor without passing any parameters!
        public Battery(string type)
        {
            this.Type = type;
        }
        // Ctor with parameters type,hours
        public Battery(string type,float hours) : this(type)
        {
            this.Hours = hours;
        }

        // properties prop  + get + set     
        public string Type 
        {
            get
            {
                return this.type;
            }
            set
            {
                //  Except  Handling 
                if (value != null && value.Length <1)
                {
                    throw new ArgumentException("Invalid argument!");
                }
                this.type = value;
            }
        }

        public float Hours 
        {
            get
            {
                return this.hours;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Sorry can not be negative.");
                }
                this.hours = value;
            }
        }

        // A method ToString();
        public override string ToString()
        {
            StringBuilder resultStr = new StringBuilder();
            // Logic 
            if (this.type != null)
            {
                resultStr.AppendLine("battery: " + this.Type);
            }

            if (this.Hours > 0)
            {
                resultStr.AppendLine("battery life: " + this.Hours + "hours");
            }

            return resultStr.ToString();
        }



    }
}
