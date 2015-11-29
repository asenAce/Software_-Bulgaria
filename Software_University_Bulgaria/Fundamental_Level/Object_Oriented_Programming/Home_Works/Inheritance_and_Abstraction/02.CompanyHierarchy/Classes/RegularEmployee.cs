using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CompanyHierarchy
{
    class RegularEmployee : Employee
    {

        protected RegularEmployee(int iD,string firstName,string lastName,Departments department,decimal salary)
            : base(iD,firstName,lastName,department,salary)
        {

        }

    }
}
