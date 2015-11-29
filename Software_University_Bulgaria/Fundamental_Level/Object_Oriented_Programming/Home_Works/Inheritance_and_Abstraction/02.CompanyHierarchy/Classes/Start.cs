using _02.CompanyHierarchy.Classes;
using _02.CompanyHierarchy.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CompanyHierarchy
{
    class Start
    {
        static void Main()
        {
            SalesEmployee retailer = new SalesEmployee(12,"Jonny","Bravo",Departments.Marketing,500,new Sale("iPod",330));

            Employee[] employees = 
            {
                retailer,
                // new Manager(45," the boss","the company ",Departments.Marketing,234,new Sale("Something",3)),  // !PROBLEM!!
               //  new Developer(445," a name","the company ", Departments.Products,2220,new Project("the name of the project")),
                   new SalesEmployee(332," a name ","in the  company ", Departments.Accounting,1200,new Sale("Something",0)),
            };

            foreach (var employee in employees)
            {
                Console.WriteLine(employees);
            }

        }
    }
}
