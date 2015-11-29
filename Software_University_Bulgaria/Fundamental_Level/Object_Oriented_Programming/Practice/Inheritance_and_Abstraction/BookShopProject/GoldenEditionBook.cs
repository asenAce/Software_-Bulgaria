using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._01.HomeWork
{
   public class GoldenEditionBook:Book
    {


       private const decimal _RATE = 1.3m;
       public GoldenEditionBook(string title,string author,decimal price)
           :base(title,author,price)
       {


       }

       public override decimal Price
       {
           get
           {
               return base.Price * _RATE;
           }
       }
       
    }
}
