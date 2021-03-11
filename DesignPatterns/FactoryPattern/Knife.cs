using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryPattern
{
    public abstract class Knife
    {
        public void Sharpen()
        {
            Console.WriteLine("Shapern Knife");
        }

        public void Polish()
        {
            Console.WriteLine("Polish Knife");
        }

        public void Package()
        {
            Console.WriteLine("Package Knife");
        }
    }
}
