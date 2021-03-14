using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StatePattern
{
    public class HasOneDollarState : IState
    {
        public void Dispense(VendingMachine vendingMachine)
        {
            Console.WriteLine("Releasing product");
            if (vendingMachine.GetCount() > 1)
            {
                vendingMachine.ReleaseProduct();
                vendingMachine.SetState(vendingMachine.GetIdleState());
            }
            else
            {
                vendingMachine.ReleaseProduct();
                vendingMachine.SetState(vendingMachine.GetOutOfStockState());
            }
        }

        public void EjectMoney(VendingMachine vendingMachine)
        {
            Console.WriteLine("Returning money");
        }

        public void InsertDollar(VendingMachine vendingMachine)
        {
            Console.WriteLine("Already have one dollar");            
        }
    }
}
