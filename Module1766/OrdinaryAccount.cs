using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1766
{
    internal class OrdinaryAccount : ICheckInterest
    {
        public void Interest(Account account)
        {
            if (account.Type == "Обычный")
            {

                account.Interest = account.Balance * 0.4;

                if (account.Balance < 1000)
                    account.Interest -= account.Balance * 0.2;

                if (account.Balance < 10000)
                    account.Interest -= account.Balance * 0.4;

            }
        }
    }
}
