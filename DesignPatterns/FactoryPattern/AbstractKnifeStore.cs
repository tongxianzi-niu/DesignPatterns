using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryPattern
{
    public abstract class AbstractKnifeStore
    {
        public Knife OrderKnife(string type)
        {
            Knife knife;
            knife = CreateKnife(type);
            knife.Sharpen();
            knife.Polish();
            knife.Package();

            return knife;
        }

        public abstract Knife CreateKnife(string type);
    }
}
