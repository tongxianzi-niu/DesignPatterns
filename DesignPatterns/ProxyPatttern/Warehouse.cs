using System;
using System.Collections.Generic;

namespace DesignPatterns.ProxyPatttern
{
    public class Warehouse : IOrder
    {
        private Dictionary<string, int> stock;
        private string address;
        public Warehouse(Dictionary<string, int> stock, string address)
        {
            this.stock = stock;
            this.address = address;
        }
        public void FulfillOrder(Order order)
        {
            foreach (Item item in order.ItemList)
            {
                this.stock[item.Sku] = this.stock[item.Sku] - 1;
            }
        }

        public int CurrentInventory(Item item)
        {
            if (stock.ContainsKey(item.Sku))
            {
                return stock[item.Sku];
            }

            return 0;
        }

        public string GetAddress()
        {
            return this.address;
        }
    }
}
