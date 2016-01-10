using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
     public class NameChangedEventArgs : EventArgs
    {
        public string OldValue
        { 
            get; 
            set; 
        }
        public string  NewValue 
        { 
            get; 
            set; 
        }

         
    }
}
