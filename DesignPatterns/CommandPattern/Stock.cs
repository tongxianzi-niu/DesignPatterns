using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CommandPattern
{
    public class Stock
    {
        private string Name = "ABC";
        private int Quantity = 10;

        public void Buy()
        {
            Console.WriteLine("Stock [ Name: {0}, Quantity: {1} ] bought", this.Name, this.Quantity);
        }

        public void Sell()
        {
            Console.WriteLine("Stock [ Name: {0}, Quantity: {1} ] sold", this.Name, this.Quantity);
        }
    }
}
