using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.Enums;


namespace ACM
{
    // abstract class mean a base class for other classes can not implemented an instance of a Object
    // on his own ...  = new 
    public abstract class EntityBase
    {
        public bool IsNew { get; private set; }
        public bool HasChanges { get;private set; }
        public  EntityStateOptions  EntityState { get; set; }

        public bool IsValid 
        { 
            get
            {
                return Validate();
            }
        }

        public abstract bool Validate();
        

    }
}
