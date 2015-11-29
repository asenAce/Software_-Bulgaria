using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CompanyHierarchy.IContracts
{
    class ISalesEmployee : IEmployee
    {

        List<ISale> Sales  { get; }

    }
}
