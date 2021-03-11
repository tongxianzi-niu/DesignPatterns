using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryPattern
{
    public class ChefsKnife : Knife
    {
        public ChefsKnife()
        {
            Console.WriteLine("Create Chefs Knife");
        }
    }
}
