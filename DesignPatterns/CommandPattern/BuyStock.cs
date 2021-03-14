using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommandPattern
{
    public class BuyStock : IOrder
    {
        private Stock AbcStock;

        public BuyStock(Stock abcStock)
        {
            this.AbcStock = abcStock;
        }

        public void Execute()
        {
            AbcStock.Buy();
        }
    }
}
