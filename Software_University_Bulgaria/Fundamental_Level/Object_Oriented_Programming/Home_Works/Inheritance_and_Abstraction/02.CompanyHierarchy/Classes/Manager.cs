using _02.CompanyHierarchy.IContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.CompanyHierarchy.IContracts;


namespace _02.CompanyHierarchy.Classes
{
    class Manager : Employee,IManager,IEmployee
    {
        public Manager(int iD,string firstName,string lastName,Departments department,decimal salary,List<IEmployee> employeesManaged)
            :base(iD,firstName,lastName,department,salary)
        {
            this.EmployeesManaged = employeesManaged;
        }

        public Manager(int iD, string firstName, string lastName, Departments department, decimal salary, IEmployee employeeManaged)
            : this (iD, firstName, lastName, department, salary, new List<IEmployee> {employeeManaged } )
        {

        }

        public List<IEmployee> EmployeesManaged { get; private set; }


        public override string ToString()
        {
            string result = base.ToString();
            result = result + string.Format("Role: Manager\n");
            result = result + string.Format("Employees Managed: ");

            List<string> employeeNames = new List<string>();

            foreach (var employee in this.EmployeesManaged)
            {
                employeeNames.Add(string.Format("{0} {1}",employee.firstName,employee.lastName));
            }
            result = result + string.Join(", ",employeeNames) + "";
            return result;
        }
    }
}
