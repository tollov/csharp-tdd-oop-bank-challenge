﻿using Boolean.CSharp.Main.TransactionManagement;
using Boolean.CSharp.Main.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean.CSharp.Main.Accounts
{
    public abstract class BankAccount
    {
        private decimal balance;
        private ITransactionManager transactions;

        public BankAccount(ITransactionManager transactionManager)
        {
            this.balance = 0m;
            this.transactions = transactionManager;
        }

        public void ApplyTransaction(ITransaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
