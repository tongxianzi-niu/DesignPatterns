using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FacadePattern
{
    public class Chequing : IAccount
    {
        public decimal Balance { get; set; }

        public Chequing(decimal initAmount)
        {
            this.Balance = initAmount;
            Console.WriteLine("Create Chequing Account with Init Amount: {0}", initAmount);
        }

        public void Deposit(decimal amount)
        {
            throw new NotImplementedException();
        }

        public int GetAccountNumber()
        {
            return 1;
        }

        public void Transfer(IAccount toAccount, decimal amount)
        {
            this.Balance -= amount;
            Console.WriteLine("Transfer {0} from {1} Account to {2} Account", amount, this.GetAccountName(), toAccount.GetAccountName());
        }

        public void Withdraw(decimal amount)
        {
            throw new NotImplementedException();
        }

        public void ShowBalance()
        {
            Console.WriteLine("Chequing Account Balance: {0}", this.Balance);
        }

        public string GetAccountName()
        {
            return "Chequing";
        }
    }
}
