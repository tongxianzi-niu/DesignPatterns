using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FacadePattern
{
    public class BankService
    {
        private Dictionary<int, IAccount> bankAccounts;

        public BankService()
        {
            this.bankAccounts = new Dictionary<int, IAccount>();
        }

        public int CreateNewAccount(string type, decimal initAmount)
        {
            IAccount newAccount = null;
            switch (type)
            {
                case "chequing":
                    newAccount = new Chequing(initAmount);
                    break;
                case "saving":
                    newAccount = new Saving(initAmount);
                    break;
                case "investment":
                    newAccount = new Investment(initAmount);
                    break;
                default:
                    Console.WriteLine("Invalid Account Type");
                    break;
            }

            if (newAccount != null)
            {
                this.bankAccounts.Add(newAccount.GetAccountNumber(), newAccount);
                return newAccount.GetAccountNumber();
            }

            return -1;
        }

        public void TransferMoney(int to, int from, decimal amount)
        {
            IAccount toAccount = this.bankAccounts.GetValueOrDefault(to);
            IAccount fromAccount = this.bankAccounts.GetValueOrDefault(from);
            fromAccount.Transfer(toAccount, amount);
            fromAccount.ShowBalance();
        }
    }
}
