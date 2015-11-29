using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CompanyHierarchy.IContracts
{
    internal interface IProject
    {

        string ProjectName { get;  }
        string Details { get; }
      //  ProjectState ProjectState {get;}

    }
}
