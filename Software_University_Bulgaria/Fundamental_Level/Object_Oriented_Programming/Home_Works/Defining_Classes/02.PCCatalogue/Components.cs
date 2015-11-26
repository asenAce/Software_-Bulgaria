using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PCCatalogue
{
     protected abstract class Components
      {
         private string  name;
         private string  details;
         private decimal price;

         public Components(string name, decimal price,string details = null)
         {
             this.Name = name;
             this.Details = details;
             this.Price = price;
         }

         public string Name 
         {
             get
             {
                 return this.name;
             }
                 
             set
             {
                 if (null == value)
                 {
                     throw new ArgumentNullException("Component name can not be null.");
                 }
                 this.name = value;
             }
         }

         public string Details 
         {
             get
             {
                 return this.details;
             }
             set
             {
                 this.details = value;
             }
         }

         public decimal Price 
         {
             get
             {
                 return this.price;
             }
             set
             {
                 if (value < 0 )
                 {
                     throw new ArgumentException("Price can not be a negative.");
                 }
                 this.price = value;
             }
         }

         public override string ToString()
         {
             string compToString = string.Format("Name: {0}, Price: {1:C}",this.Name,this.Price);

             if (null != this.Details)
             {
                 compToString += string.Format(",Details: {0}", this.Details);
             }
             return base.ToString();
         }

      }
}
