using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _01.HumanStudentAndWor
{
  public abstract class Human
    {

      string firstName;
      string lastName;
      private const string NAMEMATCHER = @"[A-Z][a-zA-Z\-]{1,19}";

      protected Human(string firstName,string lastName)
      {
          this.firstName = firstName;
          this.lastName = lastName;
      }

      public string FirstName
      {
          get
          {
              return this.firstName;
          }
          set
          {
              if (!Regex.IsMatch(value,Human.NAMEMATCHER))
              {
                  throw new ArgumentException("Incorrect");
              }

              this.firstName = value;
          }

      }

      public string LastName 
      {
          get
          {
              return this.lastName;
          }

          set
          {

              if (!Regex.IsMatch(value, NAMEMATCHER))
              {
                  throw new ArgumentException("Incorrect");
              }

              this.lastName = value;
          }
           
      }

      public override string ToString()
      {
          return string.Format("Name: {0} {1}",this.FirstName,this.LastName);
      } 


    }
}
