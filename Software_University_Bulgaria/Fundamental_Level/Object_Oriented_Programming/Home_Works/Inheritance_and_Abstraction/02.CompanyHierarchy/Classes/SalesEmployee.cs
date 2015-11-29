using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// showint the folder to the program.
using _02.CompanyHierarchy.IContracts;

namespace _02.CompanyHierarchy
{
    class SalesEmployee : RegularEmployee,ISalesEmployee
    {
        public SalesEmployee(int iD,string firstName,string lastName,Departments department,decimal salary,List<ISale>sales)
            : base(iD,firstName,lastName,department,salary)
        {

            this.Sales = sales;

        }

        public SalesEmployee(int iD, string firstName, string lastName, Departments department, decimal salary, ISale sale)
            : this(iD, firstName, lastName, department, salary, new List<ISale>() { sale })
        {


        }

        public List<ISale> Sales
        {
            get;
            private set;
        }

        public override string ToString()
        {
            string result = base.ToString();
            result = result + string.Format("Role: Sales Employee \n");
            result = result + string.Format("Sales made: {0}\n",this.Sales.Count);
            return result;
        }


    }
}
