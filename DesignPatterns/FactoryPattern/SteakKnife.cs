using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryPattern
{
    public class SteakKnife : Knife
    {
        public SteakKnife()
        {
            Console.WriteLine("Create Chefs Knife");
        }
    }
}
