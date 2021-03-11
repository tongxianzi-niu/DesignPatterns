using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ProxyPatttern
{
    public class Order
    {
        public Order()
        {
            this.ItemList = new List<Item>();
        }

        public List<Item> ItemList { get; set; }

        public void Add(Item item)
        {
            this.ItemList.Add(item);
        }
    }
}
