using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1766
{
    internal class Сheck
    {
        public Сheck(Account account, ICalculatorInterest calculator)
        {
            calculator.Interest(account);

        }
    }
}
