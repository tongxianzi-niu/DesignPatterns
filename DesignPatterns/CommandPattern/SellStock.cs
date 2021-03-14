using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommandPattern
{
    public class SellStock : IOrder
    {
        private Stock AbcStock;

        public SellStock(Stock abcStock)
        {
            this.AbcStock = abcStock;
        }

        public void Execute()
        {
            AbcStock.Sell();
        }
    }
}
