using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesOne
{
    class Person
    {
        public string FirstName 
        { 
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
        public int Age 
        { 
            get;
            set;
        }

        Person[] people = new Person[]
        {
            new Person() 
            {
                FirstName = "Larry",LastName = "Page",Age = 40  
            },
            new Person()
            {
                FirstName= "Steve",LastName="Jobs",Age = 56    
            },
            new Person()
            {
                FirstName = "Bill",LastName="Gay",Age= 120
            }


        };
        
    }
        
}
