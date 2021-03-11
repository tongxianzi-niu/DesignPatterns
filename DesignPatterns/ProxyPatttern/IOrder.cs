using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ProxyPatttern
{
    public interface IOrder
    {
        public void FulfillOrder(Order order);
    }
}
