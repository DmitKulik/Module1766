﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1766{
    public class SalaryAccount : Account{
        public void CalculateInterest(Account account){

            account.Interest = account.Balance * 0.5;
        }
    }
}
