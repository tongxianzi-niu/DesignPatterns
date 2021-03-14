using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StatePattern
{
    public class VendingMachine
    {
        private IState idleState;
        private IState hasOneDollarState;
        private IState outOfStockState;

        private IState currentState;
        private int count;

        public VendingMachine(int count)
        {
            idleState = new IdleState();
            hasOneDollarState = new HasOneDollarState();

            if (count > 0)
            {
                currentState = idleState;
                this.count = count;
            }
            else
            {
                currentState = outOfStockState;
                this.count = 0;
            }
        }

        public void InsertDollar()
        {
            currentState.InsertDollar(this);
        }
        public void EjectDollar()
        {
            currentState.EjectMoney(this);
        }

        public void Dispense()
        {
            currentState.Dispense(this);
        }

        public void SetState(IState state)
        {
            this.currentState = state;
        }

        public IState GetIdleState()
        {
            idleState = new IdleState();
            return idleState;
        }
        public int GetCount()
        {
            return this.count;
        }

        public void ReleaseProduct()
        {
            Console.WriteLine("Release product");
        }

        public IState GetOutOfStockState()
        {
            outOfStockState = new OutOfStockState();
            return outOfStockState;
        }

        public IState GetHasOneDollarState()
        {
            hasOneDollarState = new HasOneDollarState();
            return hasOneDollarState;
        }
    }
}
