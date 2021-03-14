using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StatePattern
{
    public class IdleState : IState
    {
        public void Dispense(VendingMachine vendingMachine)
        {
            Console.WriteLine("Payment required");         
        }

        public void EjectMoney(VendingMachine vendingMachine)
        {
            Console.WriteLine("No money to return");
        }

        public void InsertDollar(VendingMachine vendingMachine)
        {
            Console.WriteLine("Dollar inserted");
            vendingMachine.SetState(vendingMachine.GetHasOneDollarState());
        }
    }
}
