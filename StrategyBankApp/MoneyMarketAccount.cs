﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class MoneyMarketAccount : Checking
    {
        public MoneyMarketAccount(string name, decimal initialDeposit)
            :base(name, initialDeposit)
        {

        }
    }
}
