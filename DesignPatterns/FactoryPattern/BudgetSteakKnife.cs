using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryPattern
{
    public class BudgetSteakKnife : Knife
    {
        public BudgetSteakKnife()
        {
            Console.WriteLine("Create Budget Steak Knife");
        }
    }
}
