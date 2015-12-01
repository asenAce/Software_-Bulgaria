using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MunicipalBank.IFaces
{
    interface IWithdrawable
    {

        void WithdrawMoneyFromAccount(decimal amountToWithdraw);
    }
}
