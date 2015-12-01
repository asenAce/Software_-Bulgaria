using _02.MunicipalBank.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MunicipalBank.IFaces
{
    interface ICustomer
    {

        string name;

        public string Name { get; }

        CustomerType CustomerType { get; }

    }
}
