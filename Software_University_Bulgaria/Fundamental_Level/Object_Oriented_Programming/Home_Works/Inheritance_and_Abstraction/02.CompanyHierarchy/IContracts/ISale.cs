using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CompanyHierarchy.IContracts
{
    interface ISale
    {

        string ProductionName { get; }

        DateTime DateOfSale { get; }

        decimal Price { get; }
    }
}
