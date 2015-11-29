using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CompanyHierarchy
{
    class Customer : Person
    {
        private decimal netSpendingAmount;

        public Customer(int iD, string firstName, string lastName, decimal netSpendingAmount)
            : base(iD,firstName,lastName)
        {
            this.NetSpendingAmount = netSpendingAmount;
        }


        public decimal NetSpendingAmount 
        {
            get
            {
                return this.netSpendingAmount;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Incorrect.");
                }

                this.netSpendingAmount = value;
            }
        }

        public override string ToString()
        {
            string resulst = base.ToString();
            resulst = resulst + string.Format("Role: Customer \n");
            resulst = resulst + string.Format("Net spending Amount: {0:c2}\n",this.netSpendingAmount);
            return resulst;
        }


    }
}
