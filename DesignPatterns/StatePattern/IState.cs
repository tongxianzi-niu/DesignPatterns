using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StatePattern
{
    public interface IState
    {
        public void InsertDollar(VendingMachine vendingMachine);
        public void EjectMoney(VendingMachine vendingMachine);
        public void Dispense(VendingMachine vendingMachine);
    }
}
