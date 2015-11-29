using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CompanyHierarchy
{
   abstract class Employee : Person
    {
       private decimal salary;


       public Employee(int iD,string firstName,string lastName,Departments department,decimal salary)
           :base(iD,firstName,lastName)
       {

           this.Salary = salary;
           this.Department = department;
       }


       public decimal Salary 
       {
           get
           {
               return this.salary;
           }
           set
           {
               if (value < 0 )
               {
                   throw new ArgumentOutOfRangeException("Incorrect");
               }
               this.salary = value;
           }
       }

       public Departments Department { get; set; }


    }
}
