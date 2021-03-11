using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryPattern
{
    public class KnifeStore
    {
        private KnifeFatory factory;

        public KnifeStore(KnifeFatory factory)
        {
            this.factory = factory;
        }

        public Knife OrderKnife(string type)
        {
            Knife knife;
            knife = factory.CreateKnife(type);
            knife.Sharpen();
            knife.Polish();
            knife.Package();

            return knife;
        }
    }
}
