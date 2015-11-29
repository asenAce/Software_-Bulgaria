using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._01.HomeWork
{
     public class Book
    {
         private string title;      // Data field
         private string author;
         private decimal price;

         public Book(string title,string author,decimal price) // ctor
         {
             this.Title = title;
             this.Author = author;
             this.Price = price;

         }


         public string Title  // prop
         {
             get
             {
                 return this.title;
             }
            protected set
             {
                 if (value == null)
                 {
                     throw new ArgumentNullException("title can not be null");
                 }

                 this.title = value;
             }
         }
         public string Author 
         {
             get
             {
                 return this.author;
             }
         protected    set
             {
                 if (value == null)
                 {
                     throw new ArgumentNullException("The author can not be a null.");
                 }

                 this.author = value;
             }
         }
         public decimal Price
         {
             get
             {
                 return this.price;
             }
         protected    set
             {
                 if (value < 0 )
                 {
                     throw new ArgumentOutOfRangeException("can not be a negative.");
                 }

                 this.price = value;
             }
         }

         public override string ToString()
         {
             StringBuilder sb = new StringBuilder();

             sb.AppendFormat("-Type: {0}{1}",this.GetType().Name,Environment.NewLine);

             sb.AppendFormat("-Title: {0}{1}",this.Title,Environment.NewLine);

             sb.AppendFormat("-Author: {0}{1}",this.Author,Environment.NewLine);

             sb.AppendFormat("-Price: {0:F2}",this.Price);

             return sb.ToString();
         }



    }
}
