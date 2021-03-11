using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ProxyPatttern
{
    public class OrderFulfillment : IOrder
    {
        private List<Warehouse> warehouses;

        public OrderFulfillment(List<Warehouse> warehouses)
        {
            this.warehouses = warehouses;
        }

        public void FulfillOrder(Order order)
        {
            foreach (Item item in order.ItemList)
            {
                foreach (Warehouse warehouse in warehouses)
                {
                    if (warehouse.CurrentInventory(item) > 0)
                    {
                        Order newOrder = new Order();
                        newOrder.Add(item);
                        warehouse.FulfillOrder(order);
                        Console.WriteLine("Order {0} from {1}.", item.Sku, warehouse.GetAddress());
                        break;
                    }
                }
            }
        }
    }
}
