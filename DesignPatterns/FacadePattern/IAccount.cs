using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FacadePattern
{
    public interface IAccount
    {
        public void Deposit(decimal amount);
        public void Withdraw(decimal amount);
        public void Transfer(IAccount toAccount, decimal amount);
        public int GetAccountNumber();
        public void ShowBalance();
        public string GetAccountName();
    }
}
