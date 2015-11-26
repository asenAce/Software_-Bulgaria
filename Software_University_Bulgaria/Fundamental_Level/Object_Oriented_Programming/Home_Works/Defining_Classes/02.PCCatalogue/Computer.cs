using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PCCatalogue
{
    class Computer
    {

        private string name;
        private List<Components> components;

        public Computer(string name)
        {
            this.Name = name;
            this.Components = new List<Components>();
        }
        
        public Computer(string name, IList<Components> components)
            : this(name)
        {
            this.Components = components;
        }

        public string Name 
        {
            get
            {
                return this.name;
            }
            set
            {
                
                this.name = value;
            }
        }

        public IList<Components> Components
        {
            get
            {
                return this.Components;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The components can not be null!"); 
                }
                this.Components = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.Components.Sum( a=> a.Price);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Name: {0}\nPrice: {1:C}\nComponents:\n", this.Name, this.Price);

            foreach (Components component in this.Components)
            {
                sb.AppendLine(component.ToString());
            }

            return sb.ToString();
        }


    }
}
