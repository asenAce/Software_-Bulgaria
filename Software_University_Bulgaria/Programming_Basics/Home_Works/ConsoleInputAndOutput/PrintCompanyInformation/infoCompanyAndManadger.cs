using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintCompanyInformation
{
    // Creating a class where i made the methods, in the main() i will call the methods.
    class infoCompanyAndManadger    
    {

        public class Company    //class Company
        {
            public string name  //Creating a method called name {}
            {
                get ;
                set;
            }
            public string address
            { 
                get; 
                set;
            }
            public long phoneNumberOne 
            { 
                get; 
                set;
            }
            public long faxNumberOne
            { 
                get;
                set;
            }
            public string webSite
            { 
                get;
                set;
            }
            
        }

        public class Manadger   // Class Manadger
        {
            public string firstName 
            { 
                get; 
                set;
            }
            public string middleName
            {
                get;
                set;
            }
            public string lastName 
            {
                get; 
                set;
            }
            public long phoneNumberTwo 
            { 
                get;
                set; 
            }
            public byte age
            { 
                get; 
                set;  
            }
        }



    }
}
