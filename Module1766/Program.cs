using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1766
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new Account { Type = "Обычный", Balance = 100000, Interest = 2 };
            var ordinary = new Check(account, new OrdinaryAccount());
            var salary = new Check(account, new SalaryAccount());
        }
    }
}
