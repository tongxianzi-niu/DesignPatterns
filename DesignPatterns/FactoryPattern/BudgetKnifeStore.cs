using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryPattern
{
    public class BudgetKnifeStore : AbstractKnifeStore
    {
        public override Knife CreateKnife(string type)
        {
            if (type.Equals("steak"))
            {
                return new BudgetSteakKnife();
            }
            else if (type.Equals("chefs"))
            {
                return new BudgetChefsKnife();
            }
            else
            {
                return null;
            }
        }
    }
}
