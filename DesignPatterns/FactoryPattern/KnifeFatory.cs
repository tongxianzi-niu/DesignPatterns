using DesignPatterns.FactoryPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryPattern
{
    // Factory Object
    public class KnifeFatory
    {
        public Knife CreateKnife(string type)
        {
            Knife knife = null;
            if (type.Equals("steaks"))
            {
                knife = new SteakKnife();
            }
            else if (type.Equals("chefs"))
            {
                knife = new ChefsKnife();
            }

            return knife;
        }
    }
}
